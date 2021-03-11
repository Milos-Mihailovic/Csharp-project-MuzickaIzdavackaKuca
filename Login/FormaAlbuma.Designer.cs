namespace Login
{
    partial class FormaAlbuma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaAlbuma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlbumID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIzvodjac = new System.Windows.Forms.Label();
            this.btnZapamtiAlbum = new JThinButton.JThinButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.txtNazivAlbuma = new System.Windows.Forms.TextBox();
            this.dgvPesmeAlbuma = new System.Windows.Forms.DataGridView();
            this.dgvNazivPesme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPesmeAlbuma = new System.Windows.Forms.GroupBox();
            this.txtPretraziPesme = new System.Windows.Forms.TextBox();
            this.dgvPesme = new System.Windows.Forms.DataGridView();
            this.NazivPesme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxPesme = new System.Windows.Forms.GroupBox();
            this.btnPretraziPesme = new JThinButton.JThinButton();
            this.labelNazAl = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesmeAlbuma)).BeginInit();
            this.groupBoxPesmeAlbuma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesme)).BeginInit();
            this.groupBoxPesme.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelHeader;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Controls.Add(this.txtAlbumID);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.labelIzvodjac);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(756, 60);
            this.panelHeader.TabIndex = 25;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Albuma";
            // 
            // txtAlbumID
            // 
            this.txtAlbumID.Location = new System.Drawing.Point(92, 30);
            this.txtAlbumID.Name = "txtAlbumID";
            this.txtAlbumID.ReadOnly = true;
            this.txtAlbumID.Size = new System.Drawing.Size(90, 20);
            this.txtAlbumID.TabIndex = 33;
            this.txtAlbumID.TextChanged += new System.EventHandler(this.txtAlbumID_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelIzvodjac
            // 
            this.labelIzvodjac.AutoSize = true;
            this.labelIzvodjac.Font = new System.Drawing.Font("Buxton Sketch", 20.25F);
            this.labelIzvodjac.ForeColor = System.Drawing.Color.White;
            this.labelIzvodjac.Location = new System.Drawing.Point(12, 9);
            this.labelIzvodjac.Name = "labelIzvodjac";
            this.labelIzvodjac.Size = new System.Drawing.Size(69, 33);
            this.labelIzvodjac.TabIndex = 0;
            this.labelIzvodjac.Text = "Album";
            // 
            // btnZapamtiAlbum
            // 
            this.btnZapamtiAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnZapamtiAlbum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnZapamtiAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnZapamtiAlbum.BorderRadius = 5;
            this.btnZapamtiAlbum.ButtonText = "Zapamti";
            this.btnZapamtiAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZapamtiAlbum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapamtiAlbum.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapamtiAlbum.ForeColors = System.Drawing.Color.White;
            this.btnZapamtiAlbum.HoverBackground = System.Drawing.Color.White;
            this.btnZapamtiAlbum.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnZapamtiAlbum.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnZapamtiAlbum.LineThickness = 2;
            this.btnZapamtiAlbum.Location = new System.Drawing.Point(14, 9);
            this.btnZapamtiAlbum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnZapamtiAlbum.Name = "btnZapamtiAlbum";
            this.btnZapamtiAlbum.Size = new System.Drawing.Size(127, 41);
            this.btnZapamtiAlbum.TabIndex = 2;
            this.btnZapamtiAlbum.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelFooter.Controls.Add(this.btnZapamtiAlbum);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 420);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(756, 63);
            this.panelFooter.TabIndex = 26;
            // 
            // cmbZanr
            // 
            this.cmbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(235, 86);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(173, 21);
            this.cmbZanr.TabIndex = 36;
            this.cmbZanr.SelectedIndexChanged += new System.EventHandler(this.cmbZanr_SelectedIndexChanged);
            // 
            // txtNazivAlbuma
            // 
            this.txtNazivAlbuma.Location = new System.Drawing.Point(16, 86);
            this.txtNazivAlbuma.Name = "txtNazivAlbuma";
            this.txtNazivAlbuma.Size = new System.Drawing.Size(173, 20);
            this.txtNazivAlbuma.TabIndex = 34;
            // 
            // dgvPesmeAlbuma
            // 
            this.dgvPesmeAlbuma.AllowUserToAddRows = false;
            this.dgvPesmeAlbuma.AllowUserToDeleteRows = false;
            this.dgvPesmeAlbuma.AllowUserToResizeColumns = false;
            this.dgvPesmeAlbuma.AllowUserToResizeRows = false;
            this.dgvPesmeAlbuma.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesmeAlbuma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesmeAlbuma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNazivPesme,
            this.Obrisi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesmeAlbuma.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesmeAlbuma.Location = new System.Drawing.Point(6, 22);
            this.dgvPesmeAlbuma.Name = "dgvPesmeAlbuma";
            this.dgvPesmeAlbuma.ReadOnly = true;
            this.dgvPesmeAlbuma.RowHeadersVisible = false;
            this.dgvPesmeAlbuma.Size = new System.Drawing.Size(349, 260);
            this.dgvPesmeAlbuma.TabIndex = 10;
            this.dgvPesmeAlbuma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesmeAlbuma_CellContentClick);
            // 
            // dgvNazivPesme
            // 
            this.dgvNazivPesme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNazivPesme.HeaderText = "Naziv pesme";
            this.dgvNazivPesme.Name = "dgvNazivPesme";
            this.dgvNazivPesme.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(231, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Žanr:";
            // 
            // groupBoxPesmeAlbuma
            // 
            this.groupBoxPesmeAlbuma.Controls.Add(this.dgvPesmeAlbuma);
            this.groupBoxPesmeAlbuma.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBoxPesmeAlbuma.Location = new System.Drawing.Point(383, 126);
            this.groupBoxPesmeAlbuma.Name = "groupBoxPesmeAlbuma";
            this.groupBoxPesmeAlbuma.Size = new System.Drawing.Size(361, 288);
            this.groupBoxPesmeAlbuma.TabIndex = 32;
            this.groupBoxPesmeAlbuma.TabStop = false;
            this.groupBoxPesmeAlbuma.Text = "Pesme albuma";
            // 
            // txtPretraziPesme
            // 
            this.txtPretraziPesme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPretraziPesme.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPretraziPesme.Location = new System.Drawing.Point(6, 259);
            this.txtPretraziPesme.Name = "txtPretraziPesme";
            this.txtPretraziPesme.Size = new System.Drawing.Size(183, 23);
            this.txtPretraziPesme.TabIndex = 12;
            // 
            // dgvPesme
            // 
            this.dgvPesme.AllowUserToAddRows = false;
            this.dgvPesme.AllowUserToDeleteRows = false;
            this.dgvPesme.AllowUserToResizeColumns = false;
            this.dgvPesme.AllowUserToResizeRows = false;
            this.dgvPesme.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivPesme,
            this.Dodaj});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesme.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesme.Location = new System.Drawing.Point(6, 25);
            this.dgvPesme.Name = "dgvPesme";
            this.dgvPesme.ReadOnly = true;
            this.dgvPesme.RowHeadersVisible = false;
            this.dgvPesme.Size = new System.Drawing.Size(353, 225);
            this.dgvPesme.TabIndex = 9;
            this.dgvPesme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesme_CellContentClick);
            // 
            // NazivPesme
            // 
            this.NazivPesme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPesme.HeaderText = "Naziv pesme";
            this.NazivPesme.Name = "NazivPesme";
            this.NazivPesme.ReadOnly = true;
            this.NazivPesme.ToolTipText = "Naziv pesme";
            // 
            // Dodaj
            // 
            this.Dodaj.HeaderText = "Dodaj";
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.ReadOnly = true;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseColumnTextForButtonValue = true;
            // 
            // groupBoxPesme
            // 
            this.groupBoxPesme.Controls.Add(this.btnPretraziPesme);
            this.groupBoxPesme.Controls.Add(this.txtPretraziPesme);
            this.groupBoxPesme.Controls.Add(this.dgvPesme);
            this.groupBoxPesme.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBoxPesme.Location = new System.Drawing.Point(16, 126);
            this.groupBoxPesme.Name = "groupBoxPesme";
            this.groupBoxPesme.Size = new System.Drawing.Size(361, 288);
            this.groupBoxPesme.TabIndex = 31;
            this.groupBoxPesme.TabStop = false;
            this.groupBoxPesme.Text = "Pesme";
            // 
            // btnPretraziPesme
            // 
            this.btnPretraziPesme.BackColor = System.Drawing.Color.Transparent;
            this.btnPretraziPesme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnPretraziPesme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnPretraziPesme.BorderRadius = 5;
            this.btnPretraziPesme.ButtonText = "Pretraži";
            this.btnPretraziPesme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziPesme.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziPesme.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziPesme.ForeColors = System.Drawing.Color.White;
            this.btnPretraziPesme.HoverBackground = System.Drawing.Color.White;
            this.btnPretraziPesme.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnPretraziPesme.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnPretraziPesme.LineThickness = 2;
            this.btnPretraziPesme.Location = new System.Drawing.Point(211, 257);
            this.btnPretraziPesme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraziPesme.Name = "btnPretraziPesme";
            this.btnPretraziPesme.Size = new System.Drawing.Size(143, 24);
            this.btnPretraziPesme.TabIndex = 13;
            this.btnPretraziPesme.Click += new System.EventHandler(this.btnPretraziPesme_Click);
            // 
            // labelNazAl
            // 
            this.labelNazAl.AutoSize = true;
            this.labelNazAl.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelNazAl.Location = new System.Drawing.Point(12, 63);
            this.labelNazAl.Name = "labelNazAl";
            this.labelNazAl.Size = new System.Drawing.Size(112, 20);
            this.labelNazAl.TabIndex = 30;
            this.labelNazAl.Text = "Naziv albuma:";
            // 
            // FormaAlbuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 483);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.txtNazivAlbuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxPesmeAlbuma);
            this.Controls.Add(this.groupBoxPesme);
            this.Controls.Add(this.labelNazAl);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaAlbuma";
            this.Text = "FormaAlbuma";
            this.Load += new System.EventHandler(this.FormaAlbuma_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesmeAlbuma)).EndInit();
            this.groupBoxPesmeAlbuma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesme)).EndInit();
            this.groupBoxPesme.ResumeLayout(false);
            this.groupBoxPesme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIzvodjac;
        private JThinButton.JThinButton btnZapamtiAlbum;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlbumID;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.TextBox txtNazivAlbuma;
        private System.Windows.Forms.DataGridView dgvPesmeAlbuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPesmeAlbuma;
        private System.Windows.Forms.TextBox txtPretraziPesme;
        private System.Windows.Forms.DataGridView dgvPesme;
        private System.Windows.Forms.GroupBox groupBoxPesme;
        private System.Windows.Forms.Label labelNazAl;
        private JThinButton.JThinButton btnPretraziPesme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNazivPesme;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPesme;
        private System.Windows.Forms.DataGridViewButtonColumn Dodaj;
    }
}