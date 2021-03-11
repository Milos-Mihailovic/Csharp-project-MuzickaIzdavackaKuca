namespace Login
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnPesma = new System.Windows.Forms.Button();
            this.btnIzvodjac = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.albumiUC1 = new UserCon.AlbumiUC();
            this.pesmeUC1 = new UserCon.PesmeUC();
            this.izvodjacUC1 = new UserCon.IzvodjacUC();
            this.mmStudioUC1 = new UserCon.MMStudioUC();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelMain.Controls.Add(this.btnPocetna);
            this.panelMain.Controls.Add(this.btnAlbum);
            this.panelMain.Controls.Add(this.btnPesma);
            this.panelMain.Controls.Add(this.btnIzvodjac);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(194, 372);
            this.panelMain.TabIndex = 2;
            // 
            // btnPocetna
            // 
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.Location = new System.Drawing.Point(0, 117);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(194, 39);
            this.btnPocetna.TabIndex = 7;
            this.btnPocetna.Text = "     Početna";
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.FlatAppearance.BorderSize = 0;
            this.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbum.ForeColor = System.Drawing.Color.White;
            this.btnAlbum.Image = ((System.Drawing.Image)(resources.GetObject("btnAlbum.Image")));
            this.btnAlbum.Location = new System.Drawing.Point(0, 252);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(194, 39);
            this.btnAlbum.TabIndex = 6;
            this.btnAlbum.Text = "     Albumi";
            this.btnAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnPesma
            // 
            this.btnPesma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesma.FlatAppearance.BorderSize = 0;
            this.btnPesma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesma.ForeColor = System.Drawing.Color.White;
            this.btnPesma.Image = ((System.Drawing.Image)(resources.GetObject("btnPesma.Image")));
            this.btnPesma.Location = new System.Drawing.Point(0, 207);
            this.btnPesma.Name = "btnPesma";
            this.btnPesma.Size = new System.Drawing.Size(194, 39);
            this.btnPesma.TabIndex = 5;
            this.btnPesma.Text = "     Pesme";
            this.btnPesma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesma.UseVisualStyleBackColor = true;
            this.btnPesma.Click += new System.EventHandler(this.btnPesma_Click);
            // 
            // btnIzvodjac
            // 
            this.btnIzvodjac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzvodjac.FlatAppearance.BorderSize = 0;
            this.btnIzvodjac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvodjac.ForeColor = System.Drawing.Color.White;
            this.btnIzvodjac.Image = ((System.Drawing.Image)(resources.GetObject("btnIzvodjac.Image")));
            this.btnIzvodjac.Location = new System.Drawing.Point(0, 162);
            this.btnIzvodjac.Name = "btnIzvodjac";
            this.btnIzvodjac.Size = new System.Drawing.Size(194, 39);
            this.btnIzvodjac.TabIndex = 4;
            this.btnIzvodjac.Text = "     Izvođači";
            this.btnIzvodjac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzvodjac.UseVisualStyleBackColor = true;
            this.btnIzvodjac.Click += new System.EventHandler(this.btnIzvodjac_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(194, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(588, 17);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Početna";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(744, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.albumiUC1);
            this.panelContainer.Controls.Add(this.pesmeUC1);
            this.panelContainer.Controls.Add(this.izvodjacUC1);
            this.panelContainer.Controls.Add(this.mmStudioUC1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(194, 59);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(588, 313);
            this.panelContainer.TabIndex = 9;
            // 
            // albumiUC1
            // 
            this.albumiUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumiUC1.Location = new System.Drawing.Point(0, 0);
            this.albumiUC1.Name = "albumiUC1";
            this.albumiUC1.Size = new System.Drawing.Size(588, 313);
            this.albumiUC1.TabIndex = 8;
            this.albumiUC1.Load += new System.EventHandler(this.albumiUC1_Load);
            // 
            // pesmeUC1
            // 
            this.pesmeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pesmeUC1.Location = new System.Drawing.Point(0, 0);
            this.pesmeUC1.Name = "pesmeUC1";
            this.pesmeUC1.Size = new System.Drawing.Size(588, 313);
            this.pesmeUC1.TabIndex = 9;
            // 
            // izvodjacUC1
            // 
            this.izvodjacUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izvodjacUC1.Location = new System.Drawing.Point(0, 0);
            this.izvodjacUC1.Name = "izvodjacUC1";
            this.izvodjacUC1.Size = new System.Drawing.Size(588, 313);
            this.izvodjacUC1.TabIndex = 8;
            // 
            // mmStudioUC1
            // 
            this.mmStudioUC1.BackColor = System.Drawing.Color.White;
            this.mmStudioUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmStudioUC1.Location = new System.Drawing.Point(0, 0);
            this.mmStudioUC1.Name = "mmStudioUC1";
            this.mmStudioUC1.Size = new System.Drawing.Size(588, 313);
            this.mmStudioUC1.TabIndex = 0;
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelMain;
            // 
            // GlavnaForma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 372);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnIzvodjac;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnPesma;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
        private JDragControl.JDragControl jDragControl1;
        private UserCon.AlbumiUC albumiUC1;
        private UserCon.PesmeUC pesmeUC1;
        private UserCon.IzvodjacUC izvodjacUC1;
        private UserCon.MMStudioUC mmStudioUC1;
    }
}