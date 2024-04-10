namespace Kulynaria_Altashev.Forms
{
    partial class CaptchaForm
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
            this.tb_vvod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_vvod
            // 
            this.tb_vvod.Location = new System.Drawing.Point(166, 279);
            this.tb_vvod.Name = "tb_vvod";
            this.tb_vvod.Size = new System.Drawing.Size(235, 22);
            this.tb_vvod.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 177);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(166, 333);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(326, 333);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_vvod);
            this.Name = "CaptchaForm";
            this.Text = "CaptchaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptchaForm_FormClosing);
            this.Load += new System.EventHandler(this.CaptchaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_vvod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_ok;
    }
}