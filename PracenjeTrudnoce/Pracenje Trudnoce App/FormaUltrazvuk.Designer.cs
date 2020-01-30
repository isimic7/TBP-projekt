namespace Pracenje_Trudnoce_App
{
    partial class FormaUltrazvuk
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
            this.dgvUltrazvuci = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richNapomenaPopuni = new System.Windows.Forms.RichTextBox();
            this.cmbSat = new System.Windows.Forms.ComboBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLijecnici = new System.Windows.Forms.DataGridView();
            this.btnDopuniUltrazvuk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltrazvuci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUltrazvuci
            // 
            this.dgvUltrazvuci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUltrazvuci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltrazvuci.Location = new System.Drawing.Point(13, 13);
            this.dgvUltrazvuci.Name = "dgvUltrazvuci";
            this.dgvUltrazvuci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltrazvuci.Size = new System.Drawing.Size(446, 202);
            this.dgvUltrazvuci.TabIndex = 0;
            this.dgvUltrazvuci.SelectionChanged += new System.EventHandler(this.dgvUltrazvuci_SelectionChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 222);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 117);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richNapomenaPopuni
            // 
            this.richNapomenaPopuni.Location = new System.Drawing.Point(473, 105);
            this.richNapomenaPopuni.Name = "richNapomenaPopuni";
            this.richNapomenaPopuni.Size = new System.Drawing.Size(173, 80);
            this.richNapomenaPopuni.TabIndex = 2;
            this.richNapomenaPopuni.Text = "";
            // 
            // cmbSat
            // 
            this.cmbSat.FormattingEnabled = true;
            this.cmbSat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbSat.Location = new System.Drawing.Point(473, 25);
            this.cmbSat.Name = "cmbSat";
            this.cmbSat.Size = new System.Drawing.Size(59, 21);
            this.cmbSat.TabIndex = 3;
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cmbSpol.Location = new System.Drawing.Point(653, 25);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(59, 21);
            this.cmbSpol.TabIndex = 4;
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbMinute.Location = new System.Drawing.Point(558, 25);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(59, 21);
            this.cmbMinute.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Spol djeteta";
            // 
            // dgvLijecnici
            // 
            this.dgvLijecnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijecnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijecnici.Location = new System.Drawing.Point(473, 222);
            this.dgvLijecnici.Name = "dgvLijecnici";
            this.dgvLijecnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijecnici.Size = new System.Drawing.Size(298, 100);
            this.dgvLijecnici.TabIndex = 10;
            // 
            // btnDopuniUltrazvuk
            // 
            this.btnDopuniUltrazvuk.Location = new System.Drawing.Point(473, 345);
            this.btnDopuniUltrazvuk.Name = "btnDopuniUltrazvuk";
            this.btnDopuniUltrazvuk.Size = new System.Drawing.Size(106, 48);
            this.btnDopuniUltrazvuk.TabIndex = 11;
            this.btnDopuniUltrazvuk.Text = "Dopuni ultrazvuk";
            this.btnDopuniUltrazvuk.UseVisualStyleBackColor = true;
            this.btnDopuniUltrazvuk.Click += new System.EventHandler(this.btnDopuniUltrazvuk_Click);
            // 
            // FormaUltrazvuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 438);
            this.Controls.Add(this.btnDopuniUltrazvuk);
            this.Controls.Add(this.dgvLijecnici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMinute);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.cmbSat);
            this.Controls.Add(this.richNapomenaPopuni);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvUltrazvuci);
            this.Name = "FormaUltrazvuk";
            this.Text = "FormaUltrazvuk";
            this.Load += new System.EventHandler(this.FormaUltrazvuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltrazvuci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUltrazvuci;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richNapomenaPopuni;
        private System.Windows.Forms.ComboBox cmbSat;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLijecnici;
        private System.Windows.Forms.Button btnDopuniUltrazvuk;
    }
}