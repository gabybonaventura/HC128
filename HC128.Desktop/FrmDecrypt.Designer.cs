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
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.lblIpServer = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.lblIV = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.btnAbrirImg = new System.Windows.Forms.Button();
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.btnDecryptImage = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.White;
            this.lblFiles.Location = new System.Drawing.Point(12, 132);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(160, 20);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Lista de archivos:";
            // 
            // listFiles
            // 
            this.listFiles.AllowDrop = true;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 16;
            this.listFiles.Location = new System.Drawing.Point(16, 155);
            this.listFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(211, 180);
            this.listFiles.Sorted = true;
            this.listFiles.TabIndex = 3;
            // 
            // txtIPServer
            // 
            this.txtIPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPServer.Location = new System.Drawing.Point(20, 38);
            this.txtIPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIPServer.MaxLength = 100;
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(207, 26);
            this.txtIPServer.TabIndex = 10;
            this.txtIPServer.Text = "127.0.0.1:60757";
            // 
            // lblIpServer
            // 
            this.lblIpServer.AutoSize = true;
            this.lblIpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpServer.ForeColor = System.Drawing.Color.White;
            this.lblIpServer.Location = new System.Drawing.Point(16, 15);
            this.lblIpServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpServer.Name = "lblIpServer";
            this.lblIpServer.Size = new System.Drawing.Size(87, 20);
            this.lblIpServer.TabIndex = 9;
            this.lblIpServer.Text = "IP Server";
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(16, 415);
            this.txtIV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIV.MaxLength = 4;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(211, 22);
            this.txtIV.TabIndex = 16;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIV.ForeColor = System.Drawing.Color.White;
            this.lblIV.Location = new System.Drawing.Point(12, 391);
            this.lblIV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(180, 20);
            this.lblIV.TabIndex = 15;
            this.lblIV.Text = "Vector Inicialización";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(16, 363);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.MaxLength = 4;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(211, 22);
            this.txtKey.TabIndex = 14;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.White;
            this.lblKey.Location = new System.Drawing.Point(12, 340);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(54, 20);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "Llave";
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.BackColor = System.Drawing.Color.White;
            this.btnAbrirCarpeta.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirCarpeta.Image = global::HC128.Desktop.Properties.Resources.folder;
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(123, 623);
            this.btnAbrirCarpeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(105, 53);
            this.btnAbrirCarpeta.TabIndex = 12;
            this.btnAbrirCarpeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCarpeta.UseVisualStyleBackColor = false;
            this.btnAbrirCarpeta.Visible = false;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // btnAbrirImg
            // 
            this.btnAbrirImg.BackColor = System.Drawing.Color.White;
            this.btnAbrirImg.ForeColor = System.Drawing.Color.Black;
            this.btnAbrirImg.Image = global::HC128.Desktop.Properties.Resources.Graphicloads_100_Flat_Note;
            this.btnAbrirImg.Location = new System.Drawing.Point(16, 623);
            this.btnAbrirImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirImg.Name = "btnAbrirImg";
            this.btnAbrirImg.Size = new System.Drawing.Size(105, 53);
            this.btnAbrirImg.TabIndex = 11;
            this.btnAbrirImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirImg.UseVisualStyleBackColor = false;
            this.btnAbrirImg.Visible = false;
            this.btnAbrirImg.Click += new System.EventHandler(this.btnAbrirImg_Click);
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.BackColor = System.Drawing.Color.White;
            this.btnDownloadImage.Enabled = false;
            this.btnDownloadImage.Image = global::HC128.Desktop.Properties.Resources.download;
            this.btnDownloadImage.Location = new System.Drawing.Point(16, 562);
            this.btnDownloadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(212, 53);
            this.btnDownloadImage.TabIndex = 8;
            this.btnDownloadImage.Text = "Descargar Imagen";
            this.btnDownloadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadImage.UseVisualStyleBackColor = false;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click_1);
            // 
            // btnDecryptImage
            // 
            this.btnDecryptImage.BackColor = System.Drawing.Color.White;
            this.btnDecryptImage.Image = global::HC128.Desktop.Properties.Resources.unlock;
            this.btnDecryptImage.Location = new System.Drawing.Point(16, 502);
            this.btnDecryptImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecryptImage.Name = "btnDecryptImage";
            this.btnDecryptImage.Size = new System.Drawing.Size(212, 53);
            this.btnDecryptImage.TabIndex = 7;
            this.btnDecryptImage.Text = "Desencriptar Imagen";
            this.btnDecryptImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecryptImage.UseVisualStyleBackColor = false;
            this.btnDecryptImage.Click += new System.EventHandler(this.btnDecryptImage_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::HC128.Desktop.Properties.Resources.load;
            this.btnUpdate.Location = new System.Drawing.Point(16, 78);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Image = global::HC128.Desktop.Properties.Resources.Decrypt;
            this.picBox.Location = new System.Drawing.Point(251, -2);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1066, 694);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Controls.Add(this.btnAbrirImg);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.lblIpServer);
            this.Controls.Add(this.btnDownloadImage);
            this.Controls.Add(this.btnDecryptImage);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HC-128 Desencriptar";
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
        private System.Windows.Forms.Button btnDecryptImage;
        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label lblIpServer;
        private System.Windows.Forms.Button btnAbrirImg;
        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
    }
}