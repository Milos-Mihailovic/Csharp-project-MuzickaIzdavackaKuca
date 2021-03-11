namespace Login
{
    partial class FormaZanr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaZanr));
            this.label1 = new System.Windows.Forms.Label();
            this.btnZapamti = new JThinButton.JThinButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZanrID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIzvodjac = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtNoviZanr = new System.Windows.Forms.TextBox();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Novi Žanr:";
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
            this.panelFooter.Location = new System.Drawing.Point(0, 146);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(337, 63);
            this.panelFooter.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Žanra";
            // 
            // txtZanrID
            // 
            this.txtZanrID.Location = new System.Drawing.Point(73, 37);
            this.txtZanrID.Name = "txtZanrID";
            this.txtZanrID.ReadOnly = true;
            this.txtZanrID.Size = new System.Drawing.Size(108, 20);
            this.txtZanrID.TabIndex = 11;
            this.txtZanrID.TextChanged += new System.EventHandler(this.txtZanrID_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 3);
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
            this.labelIzvodjac.Size = new System.Drawing.Size(59, 33);
            this.labelIzvodjac.TabIndex = 0;
            this.labelIzvodjac.Text = "Žanr";
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
            this.panelHeader.Controls.Add(this.txtZanrID);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.labelIzvodjac);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(337, 60);
            this.panelHeader.TabIndex = 24;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // txtNoviZanr
            // 
            this.txtNoviZanr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNoviZanr.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNoviZanr.Location = new System.Drawing.Point(114, 90);
            this.txtNoviZanr.Name = "txtNoviZanr";
            this.txtNoviZanr.Size = new System.Drawing.Size(214, 31);
            this.txtNoviZanr.TabIndex = 31;
            this.txtNoviZanr.Tag = "";
            // 
            // FormaZanr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 209);
            this.Controls.Add(this.txtNoviZanr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaZanr";
            this.Text = "FormaZanr";
            this.Load += new System.EventHandler(this.FormaZanr_Load);
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton btnZapamti;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZanrID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIzvodjac;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtNoviZanr;
    }
}