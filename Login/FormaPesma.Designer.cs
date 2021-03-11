namespace Login
{
    partial class FormaPesma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPesma));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIzvodjac = new System.Windows.Forms.Label();
            this.btnZapamti = new JThinButton.JThinButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIzvodjac = new System.Windows.Forms.ComboBox();
            this.txtNazivPesme = new System.Windows.Forms.TextBox();
            this.txtTekstopisac = new System.Windows.Forms.TextBox();
            this.txtPesme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tekstopisac:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Naziv pesme:";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelHeader;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelHeader.Controls.Add(this.label7);
            this.panelHeader.Controls.Add(this.txtID);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.labelIzvodjac);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(604, 60);
            this.panelHeader.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(124, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID pesme";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 36);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 26;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(581, 3);
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
            this.labelIzvodjac.Size = new System.Drawing.Size(76, 33);
            this.labelIzvodjac.TabIndex = 0;
            this.labelIzvodjac.Text = "Pesma";
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.Color.Transparent;
            this.btnZapamti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnZapamti.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(186)))));
            this.btnZapamti.BorderRadius = 5;
            this.btnZapamti.ButtonText = "Zapamti";
            this.btnZapamti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZapamti.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapamti.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapamti.ForeColors = System.Drawing.Color.White;
            this.btnZapamti.HoverBackground = System.Drawing.Color.White;
            this.btnZapamti.HoverBorder = System.Drawing.Color.DarkGray;
            this.btnZapamti.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(60)))), ((int)(((byte)(32)))));
            this.btnZapamti.LineThickness = 2;
            this.btnZapamti.Location = new System.Drawing.Point(14, 9);
            this.btnZapamti.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(127, 41);
            this.btnZapamti.TabIndex = 2;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelFooter.Controls.Add(this.btnZapamti);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 340);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(604, 63);
            this.panelFooter.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Izvođač:";
            // 
            // cmbIzvodjac
            // 
            this.cmbIzvodjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzvodjac.FormattingEnabled = true;
            this.cmbIzvodjac.Location = new System.Drawing.Point(129, 101);
            this.cmbIzvodjac.Name = "cmbIzvodjac";
            this.cmbIzvodjac.Size = new System.Drawing.Size(184, 21);
            this.cmbIzvodjac.TabIndex = 36;
            this.cmbIzvodjac.SelectedIndexChanged += new System.EventHandler(this.cmbIzvodjac_SelectedIndexChanged);
            // 
            // txtNazivPesme
            // 
            this.txtNazivPesme.Location = new System.Drawing.Point(129, 75);
            this.txtNazivPesme.Name = "txtNazivPesme";
            this.txtNazivPesme.Size = new System.Drawing.Size(184, 20);
            this.txtNazivPesme.TabIndex = 37;
            // 
            // txtTekstopisac
            // 
            this.txtTekstopisac.Location = new System.Drawing.Point(129, 128);
            this.txtTekstopisac.Name = "txtTekstopisac";
            this.txtTekstopisac.Size = new System.Drawing.Size(184, 20);
            this.txtTekstopisac.TabIndex = 38;
            // 
            // txtPesme
            // 
            this.txtPesme.Location = new System.Drawing.Point(322, 101);
            this.txtPesme.Multiline = true;
            this.txtPesme.Name = "txtPesme";
            this.txtPesme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPesme.Size = new System.Drawing.Size(270, 233);
            this.txtPesme.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(319, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tekst pesme:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email tekstopisac:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 180);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(184, 20);
            this.txtTelefon.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(11, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Telefon tekstopisac:";
            // 
            // FormaPesma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 403);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesme);
            this.Controls.Add(this.txtTekstopisac);
            this.Controls.Add(this.txtNazivPesme);
            this.Controls.Add(this.cmbIzvodjac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaPesma";
            this.Text = "Pesma";
            this.Load += new System.EventHandler(this.FormaPesma_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIzvodjac;
        private JThinButton.JThinButton btnZapamti;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIzvodjac;
        private System.Windows.Forms.TextBox txtNazivPesme;
        private System.Windows.Forms.TextBox txtTekstopisac;
        private System.Windows.Forms.TextBox txtPesme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
    }
}