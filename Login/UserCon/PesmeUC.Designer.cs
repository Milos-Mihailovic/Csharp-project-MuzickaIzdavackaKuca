namespace Login.UserCon
{
    partial class PesmeUC
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
            this.dgvPesma = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnKreirajPesmu = new JThinButton.JThinButton();
            this.btnPretraziPesmu = new JThinButton.JThinButton();
            this.txtPretragaPes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesma
            // 
            this.dgvPesma.AllowUserToAddRows = false;
            this.dgvPesma.AllowUserToDeleteRows = false;
            this.dgvPesma.AllowUserToResizeColumns = false;
            this.dgvPesma.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPesma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesma.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Izmeni});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesma.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPesma.Location = new System.Drawing.Point(3, 4);
            this.dgvPesma.Name = "dgvPesma";
            this.dgvPesma.ReadOnly = true;
            this.dgvPesma.RowHeadersVisible = false;
            this.dgvPesma.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesma.Size = new System.Drawing.Size(582, 215);
            this.dgvPesma.TabIndex = 11;
            this.dgvPesma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesma_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Naziv pesme";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Izvođač";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tekstopisac";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tekst pesme";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "E-mail tekstopisca";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefon tekstopisca";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            // btnKreirajPesmu
            // 
            this.btnKreirajPesmu.BackColor = System.Drawing.Color.Transparent;
            this.btnKreirajPesmu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnKreirajPesmu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnKreirajPesmu.BorderRadius = 5;
            this.btnKreirajPesmu.ButtonText = "Kreiraj pesmu";
            this.btnKreirajPesmu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKreirajPesmu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajPesmu.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajPesmu.ForeColors = System.Drawing.Color.White;
            this.btnKreirajPesmu.HoverBackground = System.Drawing.Color.White;
            this.btnKreirajPesmu.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnKreirajPesmu.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnKreirajPesmu.LineThickness = 2;
            this.btnKreirajPesmu.Location = new System.Drawing.Point(3, 225);
            this.btnKreirajPesmu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKreirajPesmu.Name = "btnKreirajPesmu";
            this.btnKreirajPesmu.Size = new System.Drawing.Size(582, 38);
            this.btnKreirajPesmu.TabIndex = 14;
            this.btnKreirajPesmu.Click += new System.EventHandler(this.btnKreirajPesmu_Click);
            // 
            // btnPretraziPesmu
            // 
            this.btnPretraziPesmu.BackColor = System.Drawing.Color.Transparent;
            this.btnPretraziPesmu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnPretraziPesmu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnPretraziPesmu.BorderRadius = 5;
            this.btnPretraziPesmu.ButtonText = "Pretraži";
            this.btnPretraziPesmu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziPesmu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziPesmu.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziPesmu.ForeColors = System.Drawing.Color.White;
            this.btnPretraziPesmu.HoverBackground = System.Drawing.Color.White;
            this.btnPretraziPesmu.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnPretraziPesmu.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnPretraziPesmu.LineThickness = 2;
            this.btnPretraziPesmu.Location = new System.Drawing.Point(338, 271);
            this.btnPretraziPesmu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraziPesmu.Name = "btnPretraziPesmu";
            this.btnPretraziPesmu.Size = new System.Drawing.Size(247, 31);
            this.btnPretraziPesmu.TabIndex = 13;
            this.btnPretraziPesmu.Click += new System.EventHandler(this.btnPretraziIzvodjaca_Click);
            // 
            // txtPretragaPes
            // 
            this.txtPretragaPes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretragaPes.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPretragaPes.Location = new System.Drawing.Point(3, 270);
            this.txtPretragaPes.Name = "txtPretragaPes";
            this.txtPretragaPes.Size = new System.Drawing.Size(328, 31);
            this.txtPretragaPes.TabIndex = 15;
            this.txtPretragaPes.Tag = "Pretraži pesmu...";
            this.txtPretragaPes.TextChanged += new System.EventHandler(this.txtPretragaPes_TextChanged);
            // 
            // PesmeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtPretragaPes);
            this.Controls.Add(this.dgvPesma);
            this.Controls.Add(this.btnKreirajPesmu);
            this.Controls.Add(this.btnPretraziPesmu);
            this.Name = "PesmeUC";
            this.Size = new System.Drawing.Size(588, 313);
            this.Load += new System.EventHandler(this.PesmeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Izmeni;
        private JThinButton.JThinButton btnKreirajPesmu;
        private JThinButton.JThinButton btnPretraziPesmu;
        private System.Windows.Forms.TextBox txtPretragaPes;
    }
}
