﻿
namespace Kulynaria_Altashev.Forms
{
    partial class AuthorizationForm
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_vhod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(220, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(360, 206);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(130, 20);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(360, 256);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(130, 20);
            this.tb_password.TabIndex = 4;
            // 
            // btn_vhod
            // 
            this.btn_vhod.Location = new System.Drawing.Point(360, 317);
            this.btn_vhod.Name = "btn_vhod";
            this.btn_vhod.Size = new System.Drawing.Size(130, 23);
            this.btn_vhod.TabIndex = 5;
            this.btn_vhod.Text = "Войти";
            this.btn_vhod.UseVisualStyleBackColor = true;
            this.btn_vhod.Click += new System.EventHandler(this.btn_vhod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Нет учетной записи?";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(360, 372);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(130, 23);
            this.btn_reg.TabIndex = 7;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_vhod);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_vhod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reg;
    }
}