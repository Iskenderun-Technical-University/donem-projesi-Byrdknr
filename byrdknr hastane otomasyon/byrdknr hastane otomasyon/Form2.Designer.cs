namespace byrdknr_hastane_otomasyon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grsbtn = new System.Windows.Forms.Button();
            this.randevubtn = new System.Windows.Forms.Button();
            this.randevualbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grsbtn
            // 
            this.grsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.grsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grsbtn.Location = new System.Drawing.Point(114, 255);
            this.grsbtn.Name = "grsbtn";
            this.grsbtn.Size = new System.Drawing.Size(169, 74);
            this.grsbtn.TabIndex = 5;
            this.grsbtn.Text = "ÇIKIŞ";
            this.grsbtn.UseVisualStyleBackColor = false;
            this.grsbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // randevubtn
            // 
            this.randevubtn.BackColor = System.Drawing.Color.Yellow;
            this.randevubtn.Location = new System.Drawing.Point(114, 140);
            this.randevubtn.Name = "randevubtn";
            this.randevubtn.Size = new System.Drawing.Size(169, 74);
            this.randevubtn.TabIndex = 4;
            this.randevubtn.Text = "RANDEVULARIM";
            this.randevubtn.UseVisualStyleBackColor = false;
            this.randevubtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // randevualbtn
            // 
            this.randevualbtn.BackColor = System.Drawing.Color.LawnGreen;
            this.randevualbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randevualbtn.Location = new System.Drawing.Point(114, 32);
            this.randevualbtn.Name = "randevualbtn";
            this.randevualbtn.Size = new System.Drawing.Size(169, 74);
            this.randevualbtn.TabIndex = 3;
            this.randevualbtn.Text = "RANDEVU AL";
            this.randevualbtn.UseVisualStyleBackColor = false;
            this.randevualbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 357);
            this.Controls.Add(this.grsbtn);
            this.Controls.Add(this.randevubtn);
            this.Controls.Add(this.randevualbtn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grsbtn;
        private System.Windows.Forms.Button randevubtn;
        private System.Windows.Forms.Button randevualbtn;
    }
}