namespace Kulynaria_Altashev.Forms
{
    partial class DataForm
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
            this.tb_NameUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_otchestvoUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FmUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_BirthdayUpdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_phoneUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_AdressUpdate = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // tb_NameUpdate
            // 
            this.tb_NameUpdate.Location = new System.Drawing.Point(221, 49);
            this.tb_NameUpdate.Name = "tb_NameUpdate";
            this.tb_NameUpdate.Size = new System.Drawing.Size(200, 20);
            this.tb_NameUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отчество";
            // 
            // tb_otchestvoUpdate
            // 
            this.tb_otchestvoUpdate.Location = new System.Drawing.Point(221, 97);
            this.tb_otchestvoUpdate.Name = "tb_otchestvoUpdate";
            this.tb_otchestvoUpdate.Size = new System.Drawing.Size(200, 20);
            this.tb_otchestvoUpdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // tb_FmUpdate
            // 
            this.tb_FmUpdate.Location = new System.Drawing.Point(221, 137);
            this.tb_FmUpdate.Name = "tb_FmUpdate";
            this.tb_FmUpdate.Size = new System.Drawing.Size(200, 20);
            this.tb_FmUpdate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // dt_BirthdayUpdate
            // 
            this.dt_BirthdayUpdate.Location = new System.Drawing.Point(221, 177);
            this.dt_BirthdayUpdate.Name = "dt_BirthdayUpdate";
            this.dt_BirthdayUpdate.Size = new System.Drawing.Size(200, 20);
            this.dt_BirthdayUpdate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // tb_phoneUpdate
            // 
            this.tb_phoneUpdate.Location = new System.Drawing.Point(221, 222);
            this.tb_phoneUpdate.Name = "tb_phoneUpdate";
            this.tb_phoneUpdate.Size = new System.Drawing.Size(200, 20);
            this.tb_phoneUpdate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес";
            // 
            // tb_AdressUpdate
            // 
            this.tb_AdressUpdate.Location = new System.Drawing.Point(221, 264);
            this.tb_AdressUpdate.Name = "tb_AdressUpdate";
            this.tb_AdressUpdate.Size = new System.Drawing.Size(200, 20);
            this.tb_AdressUpdate.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(320, 319);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 56);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_AdressUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_phoneUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_BirthdayUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_FmUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_otchestvoUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_NameUpdate);
            this.Controls.Add(this.label1);
            this.Name = "DataForm";
            this.Text = "Профиль пользователя";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NameUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_otchestvoUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FmUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_BirthdayUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_phoneUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_AdressUpdate;
        private System.Windows.Forms.Button btn_save;
    }
}