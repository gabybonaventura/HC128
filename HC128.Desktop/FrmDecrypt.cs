using HC128.Desktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private static string IPRegex = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        public FrmDecrypt()
        {
            InitializeComponent();
        }

        private async Task UpdateListFilesAsync()
        {
            List<string> ListFiles = await API.GetImageName(txtIPServer.Text);
            listFiles.Items.Clear();
            foreach (string imageName in ListFiles)
            {
                listFiles.Items.Add(imageName);
            }   
        }

        private bool BeforeDownloadFile()
        {
            // Errors list
            List<string> errors = new List<string>();

            // Validate IP Server
            Regex regex = new Regex(IPRegex);
            var ipServer = txtIPServer.Text;
            if (!regex.IsMatch(ipServer))
                errors.Add("IP Invalida.");

            // Validate FileName
            var fileName = (string) listFiles.SelectedItem;
            if (fileName == null)
                errors.Add("Debe seleccionar un archivo.");

            // Validate FileName
            var streamKey = txtStreamKey.Text;
            if (streamKey.Length == 0)
                errors.Add("Debe insertar una Stream Key.");

            // Show messagebox
            if (errors.Count() > 0)
            {
                string caption = "Error/es encontrados";
                string message = String.Join("\n", errors);
                MessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async Task DecryptFile()
        {
            ImgAPI imgApi = await API
                .GetImageDetail(txtIPServer.Text, listFiles.SelectedItem.ToString());

            ImgDTO imgDto = new ImgDTO(
                listFiles.SelectedItem.ToString()
                , null
                , Encoding.ASCII.GetBytes(imgApi.imageByteArray));

            picBox.Image = imgDto.ToBitmap();
        }

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {
            
        }
        
        private async Task btnDownloadImage_Click(object sender, EventArgs e)
        {
            var isValidated = BeforeDownloadFile();
            if (isValidated)
            {
                await DecryptFile();
                btnDownloadImage.Enabled = true;
            }
        }

        private void btnDownloadImage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateListFilesAsync();
        }
    }
}
