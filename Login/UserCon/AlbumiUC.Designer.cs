namespace Login.UserCon
{
    partial class AlbumiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlbumi = new System.Windows.Forms.DataGridView();
            this.groupBoxAlbuma = new System.Windows.Forms.GroupBox();
            this.dgvZanrovi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivZanrova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnZanr = new JThinButton.JThinButton();
            this.groupBoxZanr = new System.Windows.Forms.GroupBox();
            this.btnAlbum = new JThinButton.JThinButton();
            this.dgvNazivAlbuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesme = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumi)).BeginInit();
            this.groupBoxAlbuma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).BeginInit();
            this.groupBoxZanr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlbumi
            // 
            this.dgvAlbumi.AllowUserToAddRows = false;
            this.dgvAlbumi.AllowUserToDeleteRows = false;
            this.dgvAlbumi.AllowUserToResizeColumns = false;
            this.dgvAlbumi.AllowUserToResizeRows = false;
            this.dgvAlbumi.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlbumi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNazivAlbuma,
            this.Zanr,
            this.Pesme,
            this.Obrisi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbumi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlbumi.Location = new System.Drawing.Point(6, 22);
            this.dgvAlbumi.Name = "dgvAlbumi";
            this.dgvAlbumi.ReadOnly = true;
            this.dgvAlbumi.RowHeadersVisible = false;
            this.dgvAlbumi.Size = new System.Drawing.Size(420, 240);
            this.dgvAlbumi.TabIndex = 10;
            this.dgvAlbumi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesmeAl_CellContentClick);
            // 
            // groupBoxAlbuma
            // 
            this.groupBoxAlbuma.Controls.Add(this.dgvAlbumi);
            this.groupBoxAlbuma.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBoxAlbuma.Location = new System.Drawing.Point(153, 42);
            this.groupBoxAlbuma.Name = "groupBoxAlbuma";
            this.groupBoxAlbuma.Size = new System.Drawing.Size(432, 268);
            this.groupBoxAlbuma.TabIndex = 6;
            this.groupBoxAlbuma.TabStop = false;
            this.groupBoxAlbuma.Text = "Albumi";
            // 
            // dgvZanrovi
            // 
            this.dgvZanrovi.AllowUserToAddRows = false;
            this.dgvZanrovi.AllowUserToDeleteRows = false;
            this.dgvZanrovi.AllowUserToResizeColumns = false;
            this.dgvZanrovi.AllowUserToResizeRows = false;
            this.dgvZanrovi.BackgroundColor = System.Drawing.Color.White;
            this.dgvZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanrovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NazivZanrova});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZanrovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZanrovi.Location = new System.Drawing.Point(3, 22);
            this.dgvZanrovi.Name = "dgvZanrovi";
            this.dgvZanrovi.ReadOnly = true;
            this.dgvZanrovi.RowHeadersVisible = false;
            this.dgvZanrovi.Size = new System.Drawing.Size(133, 240);
            this.dgvZanrovi.TabIndex = 9;
            this.dgvZanrovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZanrovi_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // NazivZanrova
            // 
            this.NazivZanrova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivZanrova.HeaderText = "Naziv Zanrova";
            this.NazivZanrova.Name = "NazivZanrova";
            this.NazivZanrova.ReadOnly = true;
            // 
            // btnZanr
            // 
            this.btnZanr.BackColor = System.Drawing.Color.Transparent;
            this.btnZanr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnZanr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnZanr.BorderRadius = 5;
            this.btnZanr.ButtonText = "Kreiraj žanr";
            this.btnZanr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZanr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.ForeColors = System.Drawing.Color.White;
            this.btnZanr.HoverBackground = System.Drawing.Color.White;
            this.btnZanr.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnZanr.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnZanr.LineThickness = 2;
            this.btnZanr.Location = new System.Drawing.Point(3, 5);
            this.btnZanr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(219, 35);
            this.btnZanr.TabIndex = 11;
            this.btnZanr.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBoxZanr
            // 
            this.groupBoxZanr.Controls.Add(this.dgvZanrovi);
            this.groupBoxZanr.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBoxZanr.Location = new System.Drawing.Point(3, 42);
            this.groupBoxZanr.Name = "groupBoxZanr";
            this.groupBoxZanr.Size = new System.Drawing.Size(144, 268);
            this.groupBoxZanr.TabIndex = 5;
            this.groupBoxZanr.TabStop = false;
            this.groupBoxZanr.Text = "Zanrovi";
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnAlbum.BorderRadius = 5;
            this.btnAlbum.ButtonText = "Kreiraj album";
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbum.ForeColors = System.Drawing.Color.White;
            this.btnAlbum.HoverBackground = System.Drawing.Color.White;
            this.btnAlbum.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnAlbum.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnAlbum.LineThickness = 2;
            this.btnAlbum.Location = new System.Drawing.Point(360, 5);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(219, 35);
            this.btnAlbum.TabIndex = 12;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // dgvNazivAlbuma
            // 
            this.dgvNazivAlbuma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNazivAlbuma.HeaderText = "Naziv albuma";
            this.dgvNazivAlbuma.Name = "dgvNazivAlbuma";
            this.dgvNazivAlbuma.ReadOnly = true;
            // 
            // Zanr
            // 
            this.Zanr.HeaderText = "Zanr";
            this.Zanr.Name = "Zanr";
            this.Zanr.ReadOnly = true;
            this.Zanr.Width = 70;
            // 
            // Pesme
            // 
            this.Pesme.HeaderText = "Pesme";
            this.Pesme.Name = "Pesme";
            this.Pesme.ReadOnly = true;
            this.Pesme.Text = "Pesme";
            this.Pesme.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 60;
            // 
            // AlbumiUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnZanr);
            this.Controls.Add(this.groupBoxAlbuma);
            this.Controls.Add(this.groupBoxZanr);
            this.Name = "AlbumiUC";
            this.Size = new System.Drawing.Size(588, 313);
            this.Load += new System.EventHandler(this.AlbumiUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumi)).EndInit();
            this.groupBoxAlbuma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).EndInit();
            this.groupBoxZanr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbumi;
        private System.Windows.Forms.GroupBox groupBoxAlbuma;
        private System.Windows.Forms.DataGridView dgvZanrovi;
        private JThinButton.JThinButton btnZanr;
        private System.Windows.Forms.GroupBox groupBoxZanr;
        private JThinButton.JThinButton btnAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivZanrova;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNazivAlbuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewButtonColumn Pesme;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}
