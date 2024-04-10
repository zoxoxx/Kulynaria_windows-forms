namespace Kulynaria_Altashev.Forms
{
    partial class ChangeRecept
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
            this.tb_recept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_changeRecept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_recept
            // 
            this.tb_recept.Location = new System.Drawing.Point(209, 13);
            this.tb_recept.Multiline = true;
            this.tb_recept.Name = "tb_recept";
            this.tb_recept.Size = new System.Drawing.Size(579, 341);
            this.tb_recept.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Измените ваш рецепт";
            // 
            // btn_changeRecept
            // 
            this.btn_changeRecept.Location = new System.Drawing.Point(39, 86);
            this.btn_changeRecept.Name = "btn_changeRecept";
            this.btn_changeRecept.Size = new System.Drawing.Size(97, 81);
            this.btn_changeRecept.TabIndex = 2;
            this.btn_changeRecept.Text = "Изменить";
            this.btn_changeRecept.UseVisualStyleBackColor = true;
            this.btn_changeRecept.Click += new System.EventHandler(this.btn_changeRecept_Click);
            // 
            // ChangeRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_changeRecept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_recept);
            this.Name = "ChangeRecept";
            this.Text = "ChangeRecept";
            this.Load += new System.EventHandler(this.ChangeRecept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_recept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_changeRecept;
    }
}