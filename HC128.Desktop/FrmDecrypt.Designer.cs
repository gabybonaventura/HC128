namespace HC128.Desktop
{
    partial class FrmDecrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiles = new System.Windows.Forms.Label();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.lblStreamKey = new System.Windows.Forms.Label();
            this.txtStreamKey = new System.Windows.Forms.TextBox();
            this.btnDecryptImage = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.lblIpServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.White;
            this.lblFiles.Location = new System.Drawing.Point(9, 113);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(130, 16);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Lista de archivos:";
            // 
            // listFiles
            // 
            this.listFiles.AllowDrop = true;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 132);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(159, 147);
            this.listFiles.Sorted = true;
            this.listFiles.TabIndex = 3;
            // 
            // lblStreamKey
            // 
            this.lblStreamKey.AutoSize = true;
            this.lblStreamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreamKey.ForeColor = System.Drawing.Color.White;
            this.lblStreamKey.Location = new System.Drawing.Point(12, 282);
            this.lblStreamKey.Name = "lblStreamKey";
            this.lblStreamKey.Size = new System.Drawing.Size(91, 16);
            this.lblStreamKey.TabIndex = 5;
            this.lblStreamKey.Text = "Stream Key:";
            // 
            // txtStreamKey
            // 
            this.txtStreamKey.Location = new System.Drawing.Point(12, 301);
            this.txtStreamKey.Name = "txtStreamKey";
            this.txtStreamKey.Size = new System.Drawing.Size(159, 20);
            this.txtStreamKey.TabIndex = 6;
            // 
            // btnDecryptImage
            // 
            this.btnDecryptImage.BackColor = System.Drawing.Color.White;
            this.btnDecryptImage.Image = global::HC128.Desktop.Properties.Resources.unlock;
            this.btnDecryptImage.Location = new System.Drawing.Point(12, 328);
            this.btnDecryptImage.Name = "btnDecryptImage";
            this.btnDecryptImage.Size = new System.Drawing.Size(159, 43);
            this.btnDecryptImage.TabIndex = 7;
            this.btnDecryptImage.Text = "Desencriptar Imagen";
            this.btnDecryptImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecryptImage.UseVisualStyleBackColor = false;
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(177, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(595, 537);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::HC128.Desktop.Properties.Resources.load;
            this.btnUpdate.Location = new System.Drawing.Point(12, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.BackColor = System.Drawing.Color.White;
            this.btnDownloadImage.Enabled = false;
            this.btnDownloadImage.Image = global::HC128.Desktop.Properties.Resources.download;
            this.btnDownloadImage.Location = new System.Drawing.Point(12, 506);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(159, 43);
            this.btnDownloadImage.TabIndex = 8;
            this.btnDownloadImage.Text = "Descargar Imagen";
            this.btnDownloadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadImage.UseVisualStyleBackColor = false;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click_1);
            // 
            // txtIPServer
            // 
            this.txtIPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPServer.Location = new System.Drawing.Point(15, 31);
            this.txtIPServer.MaxLength = 15;
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(156, 22);
            this.txtIPServer.TabIndex = 10;
            this.txtIPServer.Text = "127.0.0.1:54986";
            // 
            // lblIpServer
            // 
            this.lblIpServer.AutoSize = true;
            this.lblIpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpServer.ForeColor = System.Drawing.Color.White;
            this.lblIpServer.Location = new System.Drawing.Point(12, 12);
            this.lblIpServer.Name = "lblIpServer";
            this.lblIpServer.Size = new System.Drawing.Size(72, 16);
            this.lblIpServer.TabIndex = 9;
            this.lblIpServer.Text = "IP Server";
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.lblIpServer);
            this.Controls.Add(this.btnDownloadImage);
            this.Controls.Add(this.btnDecryptImage);
            this.Controls.Add(this.txtStreamKey);
            this.Controls.Add(this.lblStreamKey);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HC-128 Demo";
            this.Load += new System.EventHandler(this.FrmDecrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblStreamKey;
        private System.Windows.Forms.TextBox txtStreamKey;
        private System.Windows.Forms.Button btnDecryptImage;
        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label lblIpServer;
    }
}