namespace film_arsivim
{
    partial class Elestiriler
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
            this.dgvElestiriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElestiriler
            // 
            this.dgvElestiriler.AllowUserToAddRows = false;
            this.dgvElestiriler.AllowUserToDeleteRows = false;
            this.dgvElestiriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElestiriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElestiriler.Location = new System.Drawing.Point(13, 205);
            this.dgvElestiriler.Name = "dgvElestiriler";
            this.dgvElestiriler.ReadOnly = true;
            this.dgvElestiriler.Size = new System.Drawing.Size(775, 233);
            this.dgvElestiriler.TabIndex = 0;
            // 
            // Elestiriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvElestiriler);
            this.Name = "Elestiriler";
            this.Text = "Elestiriler";
            this.Load += new System.EventHandler(this.Elestiriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElestiriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElestiriler;
    }
}