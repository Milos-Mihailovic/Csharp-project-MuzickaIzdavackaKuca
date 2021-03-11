namespace Login
{
    partial class FormaIzvodjac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaIzvodjac));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIzvodjac = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnZapamti = new JThinButton.JThinButton();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new JTextBox.JTextBox();
            this.txtPrezime = new JTextBox.JTextBox();
            this.txtTrajanjeUgovora = new JTextBox.JTextBox();
            this.txtEmail = new JTextBox.JTextBox();
            this.txtTelefon = new JTextBox.JTextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Controls.Add(this.txtID);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.labelIzvodjac);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(439, 60);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID izvođača";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 36);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(108, 20);
            this.txtID.TabIndex = 11;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(414, 3);
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
            this.labelIzvodjac.Location = new System.Drawing.Point(8, 9);
            this.labelIzvodjac.Name = "labelIzvodjac";
            this.labelIzvodjac.Size = new System.Drawing.Size(84, 33);
            this.labelIzvodjac.TabIndex = 0;
            this.labelIzvodjac.Text = "Izvođač";
            this.labelIzvodjac.Click += new System.EventHandler(this.labelIzvodjac_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelFooter.Controls.Add(this.btnZapamti);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 340);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(439, 63);
            this.panelFooter.TabIndex = 1;
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
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelHeader;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trajanje ugovora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.BorderColor = System.Drawing.Color.DarkGray;
            this.txtIme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIme.Hint = "";
            this.txtIme.IsPassword = false;
            this.txtIme.Length = 0;
            this.txtIme.Location = new System.Drawing.Point(114, 81);
            this.txtIme.Name = "txtIme";
            this.txtIme.OnFocus = System.Drawing.Color.DarkGray;
            this.txtIme.OnlyChar = false;
            this.txtIme.OnlyNumber = false;
            this.txtIme.Size = new System.Drawing.Size(320, 45);
            this.txtIme.TabIndex = 19;
            this.txtIme.TextValue = "";
            this.txtIme.Load += new System.EventHandler(this.txtIme_Load);
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.AutoSize = true;
            this.txtPrezime.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrezime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrezime.Hint = "";
            this.txtPrezime.IsPassword = false;
            this.txtPrezime.Length = 0;
            this.txtPrezime.Location = new System.Drawing.Point(114, 132);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.OnFocus = System.Drawing.Color.DarkGray;
            this.txtPrezime.OnlyChar = false;
            this.txtPrezime.OnlyNumber = false;
            this.txtPrezime.Size = new System.Drawing.Size(320, 45);
            this.txtPrezime.TabIndex = 20;
            this.txtPrezime.TextValue = "";
            // 
            // txtTrajanjeUgovora
            // 
            this.txtTrajanjeUgovora.AutoSize = true;
            this.txtTrajanjeUgovora.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTrajanjeUgovora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrajanjeUgovora.Hint = "";
            this.txtTrajanjeUgovora.IsPassword = false;
            this.txtTrajanjeUgovora.Length = 0;
            this.txtTrajanjeUgovora.Location = new System.Drawing.Point(114, 183);
            this.txtTrajanjeUgovora.Name = "txtTrajanjeUgovora";
            this.txtTrajanjeUgovora.OnFocus = System.Drawing.Color.DarkGray;
            this.txtTrajanjeUgovora.OnlyChar = false;
            this.txtTrajanjeUgovora.OnlyNumber = false;
            this.txtTrajanjeUgovora.Size = new System.Drawing.Size(320, 45);
            this.txtTrajanjeUgovora.TabIndex = 21;
            this.txtTrajanjeUgovora.TextValue = "";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Hint = "";
            this.txtEmail.IsPassword = false;
            this.txtEmail.Length = 0;
            this.txtEmail.Location = new System.Drawing.Point(114, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.OnFocus = System.Drawing.Color.DarkGray;
            this.txtEmail.OnlyChar = false;
            this.txtEmail.OnlyNumber = false;
            this.txtEmail.Size = new System.Drawing.Size(320, 45);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.TextValue = "";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTelefon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefon.Hint = "";
            this.txtTelefon.IsPassword = false;
            this.txtTelefon.Length = 0;
            this.txtTelefon.Location = new System.Drawing.Point(114, 285);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.OnFocus = System.Drawing.Color.DarkGray;
            this.txtTelefon.OnlyChar = false;
            this.txtTelefon.OnlyNumber = false;
            this.txtTelefon.Size = new System.Drawing.Size(320, 45);
            this.txtTelefon.TabIndex = 23;
            this.txtTelefon.TextValue = "";
            // 
            // FormaIzvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 403);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTrajanjeUgovora);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaIzvodjac";
            this.Text = "FormaIzvodjac";
            this.Load += new System.EventHandler(this.FormaIzvodjac_Load_1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelIzvodjac;
        private System.Windows.Forms.Panel panelFooter;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private JThinButton.JThinButton btnZapamti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private JTextBox.JTextBox txtTelefon;
        private JTextBox.JTextBox txtEmail;
        private JTextBox.JTextBox txtTrajanjeUgovora;
        private JTextBox.JTextBox txtPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private JTextBox.JTextBox txtIme;
    }
}