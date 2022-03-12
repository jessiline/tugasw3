
namespace tugasw3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.labelBwh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(44, 50);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(105, 25);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input Data :";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(51, 87);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(557, 31);
            this.textBoxData.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(51, 144);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(111, 39);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // labelBwh
            // 
            this.labelBwh.AutoSize = true;
            this.labelBwh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBwh.Location = new System.Drawing.Point(51, 216);
            this.labelBwh.Name = "labelBwh";
            this.labelBwh.Size = new System.Drawing.Size(129, 41);
            this.labelBwh.TabIndex = 3;
            this.labelBwh.Text = "[EMPTY]";
            this.labelBwh.Click += new System.EventHandler(this.labelBwh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 339);
            this.Controls.Add(this.labelBwh);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label labelBwh;
    }
}

