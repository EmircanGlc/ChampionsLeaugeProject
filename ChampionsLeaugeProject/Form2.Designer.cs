
namespace ChampionsLeaugeProject
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
            this.ButtonForm2 = new System.Windows.Forms.Button();
            this.Frm2button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonForm2
            // 
            this.ButtonForm2.Location = new System.Drawing.Point(49, 390);
            this.ButtonForm2.Name = "ButtonForm2";
            this.ButtonForm2.Size = new System.Drawing.Size(250, 106);
            this.ButtonForm2.TabIndex = 0;
            this.ButtonForm2.Text = "Sonuçları Göster";
            this.ButtonForm2.UseVisualStyleBackColor = true;
            this.ButtonForm2.Click += new System.EventHandler(this.ButtonForm2_Click);
            // 
            // Frm2button1
            // 
            this.Frm2button1.Location = new System.Drawing.Point(427, 390);
            this.Frm2button1.Name = "Frm2button1";
            this.Frm2button1.Size = new System.Drawing.Size(248, 106);
            this.Frm2button1.TabIndex = 1;
            this.Frm2button1.Text = "Puan Durumu";
            this.Frm2button1.UseVisualStyleBackColor = true;
            this.Frm2button1.Click += new System.EventHandler(this.Frm2button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.Frm2button1);
            this.Controls.Add(this.ButtonForm2);
            this.Name = "Form2";
            this.Text = "Fikstür";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonForm2;
        private System.Windows.Forms.Button Frm2button1;
    }
}