namespace WebcamDemo
{
    partial class WebCam
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSources = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContainer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsViewer1 = new Dynamsoft.Forms.DSViewer();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Webcam";
            // 
            // cbxSources
            // 
            this.cbxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSources.FormattingEnabled = true;
            this.cbxSources.Location = new System.Drawing.Point(20, 43);
            this.cbxSources.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSources.Name = "cbxSources";
            this.cbxSources.Size = new System.Drawing.Size(173, 24);
            this.cbxSources.TabIndex = 13;
            this.cbxSources.SelectedIndexChanged += new System.EventHandler(this.cbxSources_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(213, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Foto";
            // 
            // lbContainer
            // 
            this.lbContainer.AutoSize = true;
            this.lbContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContainer.Location = new System.Drawing.Point(607, 20);
            this.lbContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContainer.Name = "lbContainer";
            this.lbContainer.Size = new System.Drawing.Size(49, 17);
            this.lbContainer.TabIndex = 15;
            this.lbContainer.Text = "Video";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(607, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 368);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 363);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // dsViewer1
            // 
            this.dsViewer1.Location = new System.Drawing.Point(216, 45);
            this.dsViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.dsViewer1.Name = "dsViewer1";
            this.dsViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dsViewer1.SelectionRectAspectRatio = 0D;
            this.dsViewer1.Size = new System.Drawing.Size(369, 363);
            this.dsViewer1.TabIndex = 23;
            this.dsViewer1.Load += new System.EventHandler(this.dsViewer1_Load);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Image = global::HC128.Desktop.Properties.Resources.ok;
            this.btnConfirmar.Location = new System.Drawing.Point(23, 344);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(173, 64);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Image = global::HC128.Desktop.Properties.Resources.camera;
            this.btnCaptureImage.Location = new System.Drawing.Point(23, 271);
            this.btnCaptureImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(173, 65);
            this.btnCaptureImage.TabIndex = 1;
            this.btnCaptureImage.Text = "Tomar foto";
            this.btnCaptureImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(999, 427);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dsViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSources);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCaptureImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modo web cam";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaptureImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSources;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContainer;
        private System.Windows.Forms.Panel panel1;
        private Dynamsoft.Forms.DSViewer dsViewer1;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

