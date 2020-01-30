namespace Pracenje_Trudnoce_App
{
    partial class FormKontrola
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
            this.dgvKontrola = new System.Windows.Forms.DataGridView();
            this.cmbSat = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLijecnici = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttSecer = new System.Windows.Forms.TextBox();
            this.txtHemoglobin = new System.Windows.Forms.TextBox();
            this.txtHematokrit = new System.Windows.Forms.TextBox();
            this.richSTANJE = new System.Windows.Forms.RichTextBox();
            this.txtSecer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnObrisiKontrolu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontrola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKontrola
            // 
            this.dgvKontrola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKontrola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKontrola.Location = new System.Drawing.Point(12, 12);
            this.dgvKontrola.Name = "dgvKontrola";
            this.dgvKontrola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKontrola.Size = new System.Drawing.Size(839, 143);
            this.dgvKontrola.TabIndex = 0;
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
            this.cmbSat.Location = new System.Drawing.Point(12, 188);
            this.cmbSat.Name = "cmbSat";
            this.cmbSat.Size = new System.Drawing.Size(59, 21);
            this.cmbSat.TabIndex = 4;
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbMinute.Location = new System.Drawing.Point(77, 188);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(59, 21);
            this.cmbMinute.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minute";
            // 
            // dgvLijecnici
            // 
            this.dgvLijecnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijecnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijecnici.Location = new System.Drawing.Point(142, 188);
            this.dgvLijecnici.Name = "dgvLijecnici";
            this.dgvLijecnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijecnici.Size = new System.Drawing.Size(402, 104);
            this.dgvLijecnici.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dopuni ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Obavio";
            // 
            // txttSecer
            // 
            this.txttSecer.Location = new System.Drawing.Point(12, 305);
            this.txttSecer.Name = "txttSecer";
            this.txttSecer.Size = new System.Drawing.Size(100, 20);
            this.txttSecer.TabIndex = 15;
            // 
            // txtHemoglobin
            // 
            this.txtHemoglobin.Location = new System.Drawing.Point(12, 352);
            this.txtHemoglobin.Name = "txtHemoglobin";
            this.txtHemoglobin.Size = new System.Drawing.Size(100, 20);
            this.txtHemoglobin.TabIndex = 16;
            // 
            // txtHematokrit
            // 
            this.txtHematokrit.Location = new System.Drawing.Point(12, 401);
            this.txtHematokrit.Name = "txtHematokrit";
            this.txtHematokrit.Size = new System.Drawing.Size(100, 20);
            this.txtHematokrit.TabIndex = 17;
            // 
            // richSTANJE
            // 
            this.richSTANJE.Location = new System.Drawing.Point(142, 328);
            this.richSTANJE.Name = "richSTANJE";
            this.richSTANJE.Size = new System.Drawing.Size(124, 43);
            this.richSTANJE.TabIndex = 18;
            this.richSTANJE.Text = "";
            // 
            // txtSecer
            // 
            this.txtSecer.AutoSize = true;
            this.txtSecer.Location = new System.Drawing.Point(12, 289);
            this.txtSecer.Name = "txtSecer";
            this.txtSecer.Size = new System.Drawing.Size(35, 13);
            this.txtSecer.TabIndex = 19;
            this.txtSecer.Text = "Šećer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hemoglobin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hematokrit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Stanje";
            // 
            // btnObrisiKontrolu
            // 
            this.btnObrisiKontrolu.Location = new System.Drawing.Point(580, 188);
            this.btnObrisiKontrolu.Name = "btnObrisiKontrolu";
            this.btnObrisiKontrolu.Size = new System.Drawing.Size(104, 48);
            this.btnObrisiKontrolu.TabIndex = 23;
            this.btnObrisiKontrolu.Text = "Obriši zapis";
            this.btnObrisiKontrolu.UseVisualStyleBackColor = true;
            this.btnObrisiKontrolu.Click += new System.EventHandler(this.btnObrisiKontrolu_Click);
            // 
            // FormKontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnObrisiKontrolu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSecer);
            this.Controls.Add(this.richSTANJE);
            this.Controls.Add(this.txtHematokrit);
            this.Controls.Add(this.txtHemoglobin);
            this.Controls.Add(this.txttSecer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLijecnici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMinute);
            this.Controls.Add(this.cmbSat);
            this.Controls.Add(this.dgvKontrola);
            this.Name = "FormKontrola";
            this.Text = "FormKontrola";
            this.Load += new System.EventHandler(this.FormKontrola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontrola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKontrola;
        private System.Windows.Forms.ComboBox cmbSat;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLijecnici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttSecer;
        private System.Windows.Forms.TextBox txtHemoglobin;
        private System.Windows.Forms.TextBox txtHematokrit;
        private System.Windows.Forms.RichTextBox richSTANJE;
        private System.Windows.Forms.Label txtSecer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnObrisiKontrolu;
    }
}