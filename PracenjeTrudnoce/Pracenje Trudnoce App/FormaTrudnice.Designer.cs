namespace Pracenje_Trudnoce_App
{
    partial class FormaTrudnice
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
            this.dgvTrudnice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrudnice
            // 
            this.dgvTrudnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrudnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrudnice.Location = new System.Drawing.Point(12, 12);
            this.dgvTrudnice.Name = "dgvTrudnice";
            this.dgvTrudnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrudnice.Size = new System.Drawing.Size(1103, 176);
            this.dgvTrudnice.TabIndex = 0;
            // 
            // FormaTrudnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.dgvTrudnice);
            this.Name = "FormaTrudnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaTrudnice";
            this.Load += new System.EventHandler(this.FormaTrudnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrudnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrudnice;
    }
}