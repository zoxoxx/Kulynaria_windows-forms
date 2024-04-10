namespace Kulynaria_Altashev.Forms
{
    partial class AddRecept
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
            this.btn_new_recept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_recept
            // 
            this.tb_recept.Location = new System.Drawing.Point(162, 13);
            this.tb_recept.Multiline = true;
            this.tb_recept.Name = "tb_recept";
            this.tb_recept.Size = new System.Drawing.Size(536, 394);
            this.tb_recept.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш рецепт";
            // 
            // btn_new_recept
            // 
            this.btn_new_recept.Location = new System.Drawing.Point(46, 100);
            this.btn_new_recept.Name = "btn_new_recept";
            this.btn_new_recept.Size = new System.Drawing.Size(84, 79);
            this.btn_new_recept.TabIndex = 2;
            this.btn_new_recept.Text = "Добавить";
            this.btn_new_recept.UseVisualStyleBackColor = true;
            this.btn_new_recept.Click += new System.EventHandler(this.btn_new_recept_Click);
            // 
            // AddRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_new_recept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_recept);
            this.Name = "AddRecept";
            this.Text = "AddRecept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_recept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new_recept;
    }
}