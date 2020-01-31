namespace Pracenje_Trudnoce_App
{
    partial class FormaLiječnici
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
            this.dgvLijecnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnesiLijecnika = new System.Windows.Forms.Button();
            this.btnObrisiLijecnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLijecnici
            // 
            this.dgvLijecnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLijecnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijecnici.Location = new System.Drawing.Point(15, 31);
            this.dgvLijecnici.Name = "dgvLijecnici";
            this.dgvLijecnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijecnici.Size = new System.Drawing.Size(362, 153);
            this.dgvLijecnici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liječnici";
            // 
            // btnUnesiLijecnika
            // 
            this.btnUnesiLijecnika.Location = new System.Drawing.Point(15, 219);
            this.btnUnesiLijecnika.Name = "btnUnesiLijecnika";
            this.btnUnesiLijecnika.Size = new System.Drawing.Size(108, 44);
            this.btnUnesiLijecnika.TabIndex = 2;
            this.btnUnesiLijecnika.Text = "Unesi novog liječnika";
            this.btnUnesiLijecnika.UseVisualStyleBackColor = true;
            this.btnUnesiLijecnika.Click += new System.EventHandler(this.btnUnesiLijecnika_Click);
            // 
            // btnObrisiLijecnika
            // 
            this.btnObrisiLijecnika.Location = new System.Drawing.Point(269, 219);
            this.btnObrisiLijecnika.Name = "btnObrisiLijecnika";
            this.btnObrisiLijecnika.Size = new System.Drawing.Size(108, 44);
            this.btnObrisiLijecnika.TabIndex = 3;
            this.btnObrisiLijecnika.Text = "Obriši odabranog liječnika";
            this.btnObrisiLijecnika.UseVisualStyleBackColor = true;
            this.btnObrisiLijecnika.Click += new System.EventHandler(this.btnObrisiLijecnika_Click);
            // 
            // FormaLiječnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 295);
            this.Controls.Add(this.btnObrisiLijecnika);
            this.Controls.Add(this.btnUnesiLijecnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLijecnici);
            this.Name = "FormaLiječnici";
            this.Text = "FormaLiječnici";
            this.Load += new System.EventHandler(this.FormaLiječnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijecnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLijecnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesiLijecnika;
        private System.Windows.Forms.Button btnObrisiLijecnika;
    }
}