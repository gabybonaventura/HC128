using HC128.Desktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC128.Desktop
{
    public partial class FrmDecrypt : Form
    {
        //private static string IPRegex = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        public FrmDecrypt()
        {
            InitializeComponent();
        }

        private async Task UpdateListFilesAsync()
        {
            List<string> ListFiles = await API.GetImageName(txtIPServer.Text);
            listFiles.Items.Clear();
            if(ListFiles != null)
            {
                foreach (string imageName in ListFiles)
                {
                    listFiles.Items.Add(imageName);
                }
            }
            else
            {
                ShowMessage("Error al conectarse con el servidor.", true);
            }
        }

        private bool BeforeDownloadFile()
        {
            // Errors list
            List<string> errors = new List<string>();

            // Validate IP Server
            //Regex regex = new Regex(IPRegex);
            var ipServer = txtIPServer.Text;
            if (ipServer.Length == 0)
                //if (!regex.IsMatch(ipServer))
                errors.Add("IP Invalida.");

            // Validate FileName
            var fileName = (string)listFiles.SelectedItem;
            if (fileName == null)
                errors.Add("Debe seleccionar un archivo.");

            // Validate FileName
            var streamKey = txtStreamKey.Text;
            if (streamKey.Length == 0)
                errors.Add("Debe insertar una Stream Key.");

            // Show messagebox
            if (errors.Count() > 0)
            {
                string message = String.Join("\n", errors);
                ShowMessage(message, true);
                return false;
            }
            return true;
        }

        private async Task DecryptFile()
        {
            ImgAPI imgApi = await API.GetImageDetail(txtIPServer.Text, listFiles.SelectedItem.ToString());
            
            if(imgApi != null)
            {
                Byte[] bytes = Convert.FromBase64String(imgApi.imageByteArray);
                Bitmap bitmap = ConvertImg.ToBitMap(bytes);

                picBox.Image = bitmap;
            }
            else
            {
                ShowMessage("Error al descargar la imagen.", true);
            }
        }

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {

        }

        private void btnDownloadImage_Click_1(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Save Image";
            saveFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = listFiles.SelectedItem.ToString();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    var path = saveFileDialog1.FileName;
                    //var path = listFiles.SelectedItem.ToString();
                    //var extensiones = path.Split('.');
                    //var extension = extensiones[extensiones.Count()-1];
                    Bitmap bm = new Bitmap(picBox.Image);
                    bm.Save(path, ImageFormat.Jpeg);
                    //switch (extension)
                    //{
                    //    case "jpg":
                    //        picBox.Image.Save(path, ImageFormat.Jpeg);
                    //        break;

                    //    case "jpeg":
                    //        picBox.Image.Save(path, ImageFormat.Jpeg);
                    //        break;

                    //    case "bmp":
                    //        picBox.Image.Save(path, ImageFormat.Bmp);
                    //        break;

                    //    case "png":
                    //        picBox.Image.Save(path, ImageFormat.Png);
                    //        break;

                    //    default:
                    //        picBox.Image.Save(path, ImageFormat.Jpeg);
                    //        break;
                    //}
                    myStream.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateListFilesAsync();
        }

        private void btnDecryptImage_Click(object sender, EventArgs e)
        {
            var isValidated = BeforeDownloadFile();
            if (isValidated)
            {
                DecryptFile();
                btnDownloadImage.Enabled = true;
            }
        }

        private void btnDecryptImage_Click_1(object sender, EventArgs e)
        {
            var isValidated = BeforeDownloadFile();
            if (isValidated)
            {
                DecryptFile();
                btnDownloadImage.Enabled = true;
            }
        }

        private void ShowMessage(string message, bool isError = false)
        {
            string caption = "HC-128";
            if (isError)
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
