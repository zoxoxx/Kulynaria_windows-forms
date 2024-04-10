namespace Kulynaria_Altashev.Forms
{
    partial class Data_PasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_OldPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NewPas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_PodNewPas = new System.Windows.Forms.TextBox();
            this.btn_SavePas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите старый пароль";
            // 
            // tb_OldPas
            // 
            this.tb_OldPas.Location = new System.Drawing.Point(365, 13);
            this.tb_OldPas.Name = "tb_OldPas";
            this.tb_OldPas.Size = new System.Drawing.Size(178, 20);
            this.tb_OldPas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый пароль";
            // 
            // tb_NewPas
            // 
            this.tb_NewPas.Location = new System.Drawing.Point(365, 47);
            this.tb_NewPas.Name = "tb_NewPas";
            this.tb_NewPas.Size = new System.Drawing.Size(178, 20);
            this.tb_NewPas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подствердите новый пароль";
            // 
            // tb_PodNewPas
            // 
            this.tb_PodNewPas.Location = new System.Drawing.Point(364, 82);
            this.tb_PodNewPas.Name = "tb_PodNewPas";
            this.tb_PodNewPas.Size = new System.Drawing.Size(179, 20);
            this.tb_PodNewPas.TabIndex = 5;
            // 
            // btn_SavePas
            // 
            this.btn_SavePas.Location = new System.Drawing.Point(324, 222);
            this.btn_SavePas.Name = "btn_SavePas";
            this.btn_SavePas.Size = new System.Drawing.Size(145, 53);
            this.btn_SavePas.TabIndex = 6;
            this.btn_SavePas.Text = "Сохранить";
            this.btn_SavePas.UseVisualStyleBackColor = true;
            this.btn_SavePas.Click += new System.EventHandler(this.btn_SavePas_Click);
            // 
            // Data_PasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SavePas);
            this.Controls.Add(this.tb_PodNewPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NewPas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_OldPas);
            this.Controls.Add(this.label1);
            this.Name = "Data_PasForm";
            this.Text = "Data_PasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_OldPas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NewPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PodNewPas;
        private System.Windows.Forms.Button btn_SavePas;
    }
}