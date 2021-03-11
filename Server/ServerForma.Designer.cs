namespace Server
{
    partial class Server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.panelServer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPokreni = new FlatButton.JFlatButton();
            this.btnZaustavi = new FlatButton.JFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServer
            // 
            this.panelServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelServer.Controls.Add(this.pictureBox2);
            this.panelServer.Controls.Add(this.pictureBox1);
            this.panelServer.Controls.Add(this.label1);
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServer.Location = new System.Drawing.Point(0, 0);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(317, 100);
            this.panelServer.TabIndex = 6;
            this.panelServer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelServer_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(294, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnPokreni.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnPokreni.ButtonText = "Pokreni";
            this.btnPokreni.CausesValidation = false;
            this.btnPokreni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPokreni.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnPokreni.ErrorImageLeft")));
            this.btnPokreni.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnPokreni.ErrorImageRight")));
            this.btnPokreni.FocusBackground = System.Drawing.Color.Empty;
            this.btnPokreni.FocusFontColor = System.Drawing.Color.Empty;
            this.btnPokreni.ForeColors = System.Drawing.Color.White;
            this.btnPokreni.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnPokreni.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnPokreni.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnPokreni.ImageLeft")));
            this.btnPokreni.ImageRight = null;
            this.btnPokreni.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnPokreni.Location = new System.Drawing.Point(0, 133);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnPokreni.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnPokreni.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnPokreni.Size = new System.Drawing.Size(154, 78);
            this.btnPokreni.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPokreni.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnPokreni.TabIndex = 11;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnZaustavi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnZaustavi.ButtonText = "Zaustavi";
            this.btnZaustavi.CausesValidation = false;
            this.btnZaustavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaustavi.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.ErrorImageLeft")));
            this.btnZaustavi.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.ErrorImageRight")));
            this.btnZaustavi.FocusBackground = System.Drawing.Color.Empty;
            this.btnZaustavi.FocusFontColor = System.Drawing.Color.Empty;
            this.btnZaustavi.ForeColors = System.Drawing.Color.White;
            this.btnZaustavi.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnZaustavi.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnZaustavi.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.ImageLeft")));
            this.btnZaustavi.ImageRight = null;
            this.btnZaustavi.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnZaustavi.Location = new System.Drawing.Point(163, 133);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnZaustavi.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnZaustavi.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnZaustavi.Size = new System.Drawing.Size(154, 78);
            this.btnZaustavi.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnZaustavi.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnZaustavi.TabIndex = 12;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 34);
            this.panel2.TabIndex = 10;
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelServer;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.panelServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FlatButton.JFlatButton btnPokreni;
        private FlatButton.JFlatButton btnZaustavi;
        private System.Windows.Forms.Panel panel2;
        private JDragControl.JDragControl jDragControl1;
    }
}

