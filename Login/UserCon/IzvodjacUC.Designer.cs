namespace Login.UserCon
{
    partial class IzvodjacUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIzvodjac = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnKreirajIzvodjaca = new JThinButton.JThinButton();
            this.btnPretraziIzvodjaca = new JThinButton.JThinButton();
            this.txtPretragaIzv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvodjac
            // 
            this.dgvIzvodjac.AllowUserToAddRows = false;
            this.dgvIzvodjac.AllowUserToDeleteRows = false;
            this.dgvIzvodjac.AllowUserToResizeColumns = false;
            this.dgvIzvodjac.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvIzvodjac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIzvodjac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzvodjac.BackgroundColor = System.Drawing.Color.White;
            this.dgvIzvodjac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIzvodjac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIzvodjac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvodjac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Izmeni});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIzvodjac.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIzvodjac.Location = new System.Drawing.Point(3, 3);
            this.dgvIzvodjac.Name = "dgvIzvodjac";
            this.dgvIzvodjac.ReadOnly = true;
            this.dgvIzvodjac.RowHeadersVisible = false;
            this.dgvIzvodjac.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIzvodjac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvodjac.Size = new System.Drawing.Size(582, 215);
            this.dgvIzvodjac.TabIndex = 7;
            this.dgvIzvodjac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzvodjac_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prezime";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trajanje ugovora";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "E-mail";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Izmeni
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.Izmeni.DefaultCellStyle = dataGridViewCellStyle3;
            this.Izmeni.HeaderText = "Izmeni";
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.ReadOnly = true;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseColumnTextForButtonValue = true;
            // 
            // btnKreirajIzvodjaca
            // 
            this.btnKreirajIzvodjaca.BackColor = System.Drawing.Color.Transparent;
            this.btnKreirajIzvodjaca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnKreirajIzvodjaca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnKreirajIzvodjaca.BorderRadius = 5;
            this.btnKreirajIzvodjaca.ButtonText = "Kreiraj izvođača";
            this.btnKreirajIzvodjaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKreirajIzvodjaca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajIzvodjaca.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajIzvodjaca.ForeColors = System.Drawing.Color.White;
            this.btnKreirajIzvodjaca.HoverBackground = System.Drawing.Color.White;
            this.btnKreirajIzvodjaca.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnKreirajIzvodjaca.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnKreirajIzvodjaca.LineThickness = 2;
            this.btnKreirajIzvodjaca.Location = new System.Drawing.Point(3, 225);
            this.btnKreirajIzvodjaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKreirajIzvodjaca.Name = "btnKreirajIzvodjaca";
            this.btnKreirajIzvodjaca.Size = new System.Drawing.Size(582, 38);
            this.btnKreirajIzvodjaca.TabIndex = 10;
            this.btnKreirajIzvodjaca.Click += new System.EventHandler(this.btnKreirajIzvodjaca_Click);
            // 
            // btnPretraziIzvodjaca
            // 
            this.btnPretraziIzvodjaca.BackColor = System.Drawing.Color.Transparent;
            this.btnPretraziIzvodjaca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnPretraziIzvodjaca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnPretraziIzvodjaca.BorderRadius = 5;
            this.btnPretraziIzvodjaca.ButtonText = "Pretraži";
            this.btnPretraziIzvodjaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziIzvodjaca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziIzvodjaca.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziIzvodjaca.ForeColors = System.Drawing.Color.White;
            this.btnPretraziIzvodjaca.HoverBackground = System.Drawing.Color.White;
            this.btnPretraziIzvodjaca.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnPretraziIzvodjaca.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnPretraziIzvodjaca.LineThickness = 2;
            this.btnPretraziIzvodjaca.Location = new System.Drawing.Point(338, 269);
            this.btnPretraziIzvodjaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraziIzvodjaca.Name = "btnPretraziIzvodjaca";
            this.btnPretraziIzvodjaca.Size = new System.Drawing.Size(247, 32);
            this.btnPretraziIzvodjaca.TabIndex = 9;
            this.btnPretraziIzvodjaca.Click += new System.EventHandler(this.btnPretraziIzvodjaca_Click);
            // 
            // txtPretragaIzv
            // 
            this.txtPretragaIzv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretragaIzv.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPretragaIzv.Location = new System.Drawing.Point(3, 270);
            this.txtPretragaIzv.Name = "txtPretragaIzv";
            this.txtPretragaIzv.Size = new System.Drawing.Size(328, 31);
            this.txtPretragaIzv.TabIndex = 16;
            this.txtPretragaIzv.Tag = "";
            this.txtPretragaIzv.TextChanged += new System.EventHandler(this.txtPretragaPes_TextChanged);
            // 
            // IzvodjacUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtPretragaIzv);
            this.Controls.Add(this.dgvIzvodjac);
            this.Controls.Add(this.btnKreirajIzvodjaca);
            this.Controls.Add(this.btnPretraziIzvodjaca);
            this.Name = "IzvodjacUC";
            this.Size = new System.Drawing.Size(588, 313);
            this.Load += new System.EventHandler(this.IzvodjacUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzvodjac;
        private JThinButton.JThinButton btnKreirajIzvodjaca;
        private JThinButton.JThinButton btnPretraziIzvodjaca;
        private System.Windows.Forms.TextBox txtPretragaIzv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Izmeni;
    }
}
