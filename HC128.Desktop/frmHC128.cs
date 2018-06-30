﻿using HC128.Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebcamDemo;

namespace HC128.Desktop
{
    public partial class FrmHC128 : Form
    {
        //private static string IPRegex = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        bool isCall = false;
        public FrmHC128()
        {
            InitializeComponent();
           

        }
        

        private void FrmHC128_Load(object sender, EventArgs e)
        {

        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (isCall)
            {
                string ImagePath = Path.Combine(new string[] { Environment.CurrentDirectory, "image.png" });
                picBox.Image = new Bitmap(ImagePath);
                txtNameImg.Text = "WebCam Imagen";
                EnableBtns();
                isCall = false;

            }
        }

        private void EnableBtns()
        {
            // Enable btn upload 
            btnUploadImage.Enabled = true;
        }

        private bool ValidateBeforeUpload()
        {
            // Errors list
            List<string> errors = new List<string>();

            // Validate IP Server
            var ipServer = txtIPServer.Text;
            if (ipServer.Length == 0)
                errors.Add("Debe ingresar una IP.");
            
            // PicBox
            var img = picBox.Image;
            if (img == null)
                errors.Add("No hay una imagen seleccionada.");

            // Validate FileName
            var fileName = txtNameImg.Text;
            if (fileName.Length == 0)
                errors.Add("Debe insertar un nombre.");

            // Validate Llave
            var llave = txtKey.Text;
            if (llave.Length == 0)
                errors.Add("Debe insertar una llave.");

            // Validate IV
            var iv = txtIV.Text;
            if (iv.Length == 0)
                errors.Add("Debe insertar un vector de inicialización.");

            // Show messagebox
            if (errors.Count() > 0)
            {
                string message = String.Join("\n", errors);
                ShowMessage(message, true);
                return false;
            }
            return true;
        }
        public Byte[] Encrypt(string nameFile, Bitmap bitmap)
        {
            ImgDTO img = new ImgDTO(txtNameImg.Text, (Bitmap)picBox.Image);
            return img.ToBytes();
        }

        public async Task Upload(Byte[] bytes)
        {
            string stringImg = Convert.ToBase64String(bytes);
            ImgAPI imgAPI = new ImgAPI
            {
                imageName = txtNameImg.Text,
                imageByteArray = stringImg
            };

            bool postSuccess = await API.PostImage(txtIPServer.Text, imgAPI);
            
            if (postSuccess)
                ShowMessage("Imagen encriptada y subida exitosamente..");
            else
                ShowMessage("Error al conectarse con el servidor.", true);
        }


        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    picBox.Image = new Bitmap(dlg.FileName);
                    txtNameImg.Text = dlg.SafeFileName;
                    EnableBtns();
                }
            }
        }
        
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            var isValidated = ValidateBeforeUpload();
            if (isValidated)
            {
                int i = 0, j = 0;
                UInt32[] llave = new UInt32[4];
                UInt32[] vectorinit = new UInt32[4];
                foreach (char x in txtKey.Text)
                {
                    llave[i] = UInt32.Parse(x.ToString());
                    i++;
                }

                foreach (char x in txtIV.Text)
                {
                    vectorinit[j] = UInt32.Parse(x.ToString());
                    j++;
                }

                Byte[] encrypt = Encrypt(txtNameImg.Text, (Bitmap)picBox.Image);

                Encrypt encriptar = new Encrypt(llave, vectorinit);
                encriptar.inicializacion();
                encriptar.generateKeyStream((encrypt.Length) / 4);

                Byte[] ciphertext = encriptar.generateCiphertext(encrypt);

                if(chxVistaAvanzada.Checked == true)
                {
                    FrmVistaAvanzada frmVistaAvanzada = new FrmVistaAvanzada(this,
                        Convert.ToBase64String(encrypt),
                        Convert.ToBase64String(ciphertext));
                    frmVistaAvanzada.Show();
                }
                else
                {
                    Upload(ciphertext);
                }

                
            }
        }

        private void ShowMessage(string message, bool isError = false)
        {
            string caption = "HC-128";
            if(isError)
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            isCall = true;
            WebCam webCam = new WebCam(this);
            webCam.Show();
            /*
            string ImagePath = Path.Combine(new string[] { Environment.CurrentDirectory, "image_cam.png" });
            picBox.Image = new Bitmap(ImagePath);
            txtNameImg.Text = "WebCam Imagen";
            EnableBtns();
            */
            
        }

        public void loadPicture(Bitmap bitmap)
        {
            picBox.Image = new Bitmap(bitmap);
            txtNameImg.Text = "WebCam Imagen";
            EnableBtns();
        }

    }
}
