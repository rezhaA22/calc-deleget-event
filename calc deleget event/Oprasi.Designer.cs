
namespace calc_deleget_event
{
    partial class Oprasi
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
            this.label2 = new System.Windows.Forms.Label();
            this.list_oprasi = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_proses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // list_oprasi
            // 
            this.list_oprasi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.list_oprasi.DisplayMember = "tambah";
            this.list_oprasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_oprasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.list_oprasi.FormattingEnabled = true;
            this.list_oprasi.Items.AddRange(new object[] {
            "tambah",
            "kurang",
            "kali",
            "bagi"});
            this.list_oprasi.Location = new System.Drawing.Point(178, 26);
            this.list_oprasi.Name = "list_oprasi";
            this.list_oprasi.Size = new System.Drawing.Size(121, 28);
            this.list_oprasi.TabIndex = 3;
            this.list_oprasi.ValueMember = "tambah";
            // 
            // NilaiA
            // 
            this.NilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NilaiA.Location = new System.Drawing.Point(178, 82);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(121, 26);
            this.NilaiA.TabIndex = 4;
            // 
            // NilaiB
            // 
            this.NilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NilaiB.Location = new System.Drawing.Point(178, 140);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(121, 26);
            this.NilaiB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "oprasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nilai B";
            // 
            // btn_proses
            // 
            this.btn_proses.Location = new System.Drawing.Point(196, 235);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(103, 45);
            this.btn_proses.TabIndex = 8;
            this.btn_proses.Text = "proses";
            this.btn_proses.UseVisualStyleBackColor = true;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // Oprasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 302);
            this.Controls.Add(this.btn_proses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.list_oprasi);
            this.Controls.Add(this.label2);
            this.Name = "Oprasi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Oprasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_proses;
        private System.Windows.Forms.ComboBox list_oprasi;
    }
}

