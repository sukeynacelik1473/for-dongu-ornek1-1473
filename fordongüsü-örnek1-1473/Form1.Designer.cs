namespace fordongüsü_örnek1_1473
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(25, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 53);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "YAZ";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbAd
            // 
            this.lbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAd.FormattingEnabled = true;
            this.lbAd.ItemHeight = 16;
            this.lbAd.Location = new System.Drawing.Point(154, 33);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(120, 244);
            this.lbAd.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(25, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(113, 22);
            this.txtAd.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 319);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbAd;
        private System.Windows.Forms.TextBox txtAd;
    }
}

