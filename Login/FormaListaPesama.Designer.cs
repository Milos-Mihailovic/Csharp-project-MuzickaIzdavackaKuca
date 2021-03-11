namespace Login
{
    partial class FormaListaPesama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaListaPesama));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIzvodjac = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtNazivAlbuma = new System.Windows.Forms.TextBox();
            this.txtNazivZanra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListaPesama = new System.Windows.Forms.DataGridView();
            this.NazivPesme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPesama)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 361);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(343, 38);
            this.panelFooter.TabIndex = 33;
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
            this.labelIzvodjac.Size = new System.Drawing.Size(76, 33);
            this.labelIzvodjac.TabIndex = 0;
            this.labelIzvodjac.Text = "Pesme";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelHeader;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.labelIzvodjac);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(343, 60);
            this.panelHeader.TabIndex = 32;
            // 
            // txtNazivAlbuma
            // 
            this.txtNazivAlbuma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivAlbuma.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNazivAlbuma.Location = new System.Drawing.Point(12, 93);
            this.txtNazivAlbuma.Name = "txtNazivAlbuma";
            this.txtNazivAlbuma.ReadOnly = true;
            this.txtNazivAlbuma.Size = new System.Drawing.Size(151, 31);
            this.txtNazivAlbuma.TabIndex = 35;
            this.txtNazivAlbuma.Tag = "";
            // 
            // txtNazivZanra
            // 
            this.txtNazivZanra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivZanra.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNazivZanra.Location = new System.Drawing.Point(183, 93);
            this.txtNazivZanra.Name = "txtNazivZanra";
            this.txtNazivZanra.ReadOnly = true;
            this.txtNazivZanra.Size = new System.Drawing.Size(151, 31);
            this.txtNazivZanra.TabIndex = 36;
            this.txtNazivZanra.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(179, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Žanr";
            // 
            // dgvListaPesama
            // 
            this.dgvListaPesama.AllowUserToAddRows = false;
            this.dgvListaPesama.AllowUserToDeleteRows = false;
            this.dgvListaPesama.AllowUserToResizeColumns = false;
            this.dgvListaPesama.AllowUserToResizeRows = false;
            this.dgvListaPesama.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPesama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPesama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivPesme});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPesama.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaPesama.Location = new System.Drawing.Point(12, 130);
            this.dgvListaPesama.Name = "dgvListaPesama";
            this.dgvListaPesama.ReadOnly = true;
            this.dgvListaPesama.RowHeadersVisible = false;
            this.dgvListaPesama.Size = new System.Drawing.Size(322, 225);
            this.dgvListaPesama.TabIndex = 39;
            // 
            // NazivPesme
            // 
            this.NazivPesme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPesme.HeaderText = "Naziv pesme";
            this.NazivPesme.Name = "NazivPesme";
            this.NazivPesme.ReadOnly = true;
            this.NazivPesme.ToolTipText = "Naziv pesme";
            // 
            // FormaListaPesama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 399);
            this.Controls.Add(this.dgvListaPesama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivZanra);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.txtNazivAlbuma);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaListaPesama";
            this.Text = "ListaPesama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPesama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIzvodjac;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtNazivAlbuma;
        private System.Windows.Forms.TextBox txtNazivZanra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListaPesama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPesme;
    }
}