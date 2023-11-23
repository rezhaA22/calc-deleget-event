
namespace calc_deleget_event
{
    partial class hasil
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
            this.hitung = new System.Windows.Forms.Button();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(11, 453);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(457, 52);
            this.hitung.TabIndex = 0;
            this.hitung.Text = "HITUNG ";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // listHasil
            // 
            this.listHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listHasil.FormattingEnabled = true;
            this.listHasil.ItemHeight = 16;
            this.listHasil.Location = new System.Drawing.Point(8, 21);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(455, 356);
            this.listHasil.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listHasil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(5, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASIL";
            // 
            // hasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hitung);
            this.Name = "hasil";
            this.Text = "hasil";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.ListBox listHasil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}