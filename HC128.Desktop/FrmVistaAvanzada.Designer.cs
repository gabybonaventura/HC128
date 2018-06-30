namespace HC128.Desktop
{
    partial class FrmVistaAvanzada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaAvanzada));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImgOriginal = new System.Windows.Forms.RichTextBox();
            this.txtImgEncript = new System.Windows.Forms.RichTextBox();
            this.lblImagenEncripyt = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Img Original (Base64)";
            // 
            // txtImgOriginal
            // 
            this.txtImgOriginal.Location = new System.Drawing.Point(12, 38);
            this.txtImgOriginal.Name = "txtImgOriginal";
            this.txtImgOriginal.ReadOnly = true;
            this.txtImgOriginal.Size = new System.Drawing.Size(470, 454);
            this.txtImgOriginal.TabIndex = 1;
            this.txtImgOriginal.Text = resources.GetString("txtImgOriginal.Text");
            // 
            // txtImgEncript
            // 
            this.txtImgEncript.Location = new System.Drawing.Point(500, 38);
            this.txtImgEncript.Name = "txtImgEncript";
            this.txtImgEncript.ReadOnly = true;
            this.txtImgEncript.Size = new System.Drawing.Size(470, 454);
            this.txtImgEncript.TabIndex = 3;
            this.txtImgEncript.Text = resources.GetString("txtImgEncript.Text");
            // 
            // lblImagenEncripyt
            // 
            this.lblImagenEncripyt.AutoSize = true;
            this.lblImagenEncripyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenEncripyt.Location = new System.Drawing.Point(636, 9);
            this.lblImagenEncripyt.Name = "lblImagenEncripyt";
            this.lblImagenEncripyt.Size = new System.Drawing.Size(218, 20);
            this.lblImagenEncripyt.TabIndex = 2;
            this.lblImagenEncripyt.Text = "Img Encriptada (Base64)";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.White;
            this.btnUploadImage.Image = global::HC128.Desktop.Properties.Resources.upload;
            this.btnUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadImage.Location = new System.Drawing.Point(12, 498);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(958, 43);
            this.btnUploadImage.TabIndex = 4;
            this.btnUploadImage.Text = "Subir Imagen";
            this.btnUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // FrmVistaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.txtImgEncript);
            this.Controls.Add(this.lblImagenEncripyt);
            this.Controls.Add(this.txtImgOriginal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVistaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista avanzada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtImgOriginal;
        private System.Windows.Forms.RichTextBox txtImgEncript;
        private System.Windows.Forms.Label lblImagenEncripyt;
        private System.Windows.Forms.Button btnUploadImage;
    }
}