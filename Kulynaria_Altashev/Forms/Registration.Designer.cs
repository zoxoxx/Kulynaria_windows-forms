
namespace Kulynaria_Altashev.Forms
{
    partial class Registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_fm = new System.Windows.Forms.TextBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pod_pas = new System.Windows.Forms.TextBox();
            this.btn_reg_pod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(252, 136);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 3;
            // 
            // tb_fm
            // 
            this.tb_fm.Location = new System.Drawing.Point(252, 174);
            this.tb_fm.Name = "tb_fm";
            this.tb_fm.Size = new System.Drawing.Size(100, 20);
            this.tb_fm.TabIndex = 4;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(252, 210);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(100, 20);
            this.tb_log.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            // 
            // tb_pas
            // 
            this.tb_pas.Location = new System.Drawing.Point(252, 248);
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(100, 20);
            this.tb_pas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Подтверждение пароля";
            // 
            // tb_pod_pas
            // 
            this.tb_pod_pas.Location = new System.Drawing.Point(324, 289);
            this.tb_pod_pas.Name = "tb_pod_pas";
            this.tb_pod_pas.Size = new System.Drawing.Size(100, 20);
            this.tb_pod_pas.TabIndex = 9;
            // 
            // btn_reg_pod
            // 
            this.btn_reg_pod.Location = new System.Drawing.Point(306, 335);
            this.btn_reg_pod.Name = "btn_reg_pod";
            this.btn_reg_pod.Size = new System.Drawing.Size(139, 23);
            this.btn_reg_pod.TabIndex = 10;
            this.btn_reg_pod.Text = "Зарегистрироваться";
            this.btn_reg_pod.UseVisualStyleBackColor = true;
            this.btn_reg_pod.Click += new System.EventHandler(this.btn_reg_pod_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Для регистрации необходимо заполнить все поля";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_reg_pod);
            this.Controls.Add(this.tb_pod_pas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_pas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.tb_fm);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_fm;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pod_pas;
        private System.Windows.Forms.Button btn_reg_pod;
        private System.Windows.Forms.Label label6;
    }
}