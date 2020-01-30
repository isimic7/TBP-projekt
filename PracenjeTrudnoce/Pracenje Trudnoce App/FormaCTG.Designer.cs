namespace Pracenje_Trudnoce_App
{
    partial class FormaCTG
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
            this.dgvSpremnCTG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNaruciCTG = new System.Windows.Forms.Button();
            this.dgvCTG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDopuniCTG = new System.Windows.Forms.Button();
            this.dgvLijecnici = new System.Windows.Forms.DataGridView();
            this.richOPIS = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpremnCTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpremnCTG
            // 
            this.dgvSpremnCTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpremnCTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpremnCTG.Location = new System.Drawing.Point(12, 42);
            this.dgvSpremnCTG.Name = "dgvSpremnCTG";
            this.dgvSpremnCTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpremnCTG.Size = new System.Drawing.Size(1103, 121);
            this.dgvSpremnCTG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trudnice spremne za CTG";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum CTG-a";
            // 
            // btnNaruciCTG
            // 
            this.btnNaruciCTG.Location = new System.Drawing.Point(229, 204);
            this.btnNaruciCTG.Name = "btnNaruciCTG";
            this.btnNaruciCTG.Size = new System.Drawing.Size(82, 42);
            this.btnNaruciCTG.TabIndex = 5;
            this.btnNaruciCTG.Text = "Naruči CTG";
            this.btnNaruciCTG.UseVisualStyleBackColor = true;
            this.btnNaruciCTG.Click += new System.EventHandler(this.btnNaruciCTG_Click);
            // 
            // dgvCTG
            // 
            this.dgvCTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTG.Location = new System.Drawing.Point(317, 204);
            this.dgvCTG.Name = "dgvCTG";
            this.dgvCTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTG.Size = new System.Drawing.Size(400, 164);
            this.dgvCTG.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Svi CTG pregledi";
            // 
            // btnDopuniCTG
            // 
            this.btnDopuniCTG.Location = new System.Drawing.Point(1023, 206);
            this.btnDopuniCTG.Name = "btnDopuniCTG";
            this.btnDopuniCTG.Size = new System.Drawing.Size(92, 40);
            this.btnDopuniCTG.TabIndex = 8;
            this.btnDopuniCTG.Text = "Dopuni CTG";
            this.btnDopuniCTG.UseVisualStyleBackColor = true;
            this.btnDopuniCTG.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLijecnici
            // 
            this.dgvLijecnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijecnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijecnici.Location = new System.Drawing.Point(737, 204);
            this.dgvLijecnici.Name = "dgvLijecnici";
            this.dgvLijecnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijecnici.Size = new System.Drawing.Size(280, 123);
            this.dgvLijecnici.TabIndex = 9;
            // 
            // richOPIS
            // 
            this.richOPIS.Location = new System.Drawing.Point(737, 333);
            this.richOPIS.Name = "richOPIS";
            this.richOPIS.Size = new System.Drawing.Size(241, 90);
            this.richOPIS.TabIndex = 10;
            this.richOPIS.Text = "";
            // 
            // FormaCTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.richOPIS);
            this.Controls.Add(this.dgvLijecnici);
            this.Controls.Add(this.btnDopuniCTG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCTG);
            this.Controls.Add(this.btnNaruciCTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpremnCTG);
            this.Name = "FormaCTG";
            this.Text = "FormaCTG";
            this.Load += new System.EventHandler(this.FormaCTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpremnCTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpremnCTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNaruciCTG;
        private System.Windows.Forms.DataGridView dgvCTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDopuniCTG;
        private System.Windows.Forms.DataGridView dgvLijecnici;
        private System.Windows.Forms.RichTextBox richOPIS;
    }
}