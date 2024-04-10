namespace Kulynaria_Altashev.Forms
{
    partial class UsersForm
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_users = new System.Windows.Forms.Button();
            this.btn_delete_users = new System.Windows.Forms.Button();
            this.gp_dannye = new System.Windows.Forms.GroupBox();
            this.btn_changerole = new System.Windows.Forms.Button();
            this.cb_roles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_adress_users = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fm_users = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_otchestvo_users = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.gp_dannye.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_users.Location = new System.Drawing.Point(12, 35);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.Size = new System.Drawing.Size(555, 150);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_users_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фамилия";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Роль";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btn_add_users
            // 
            this.btn_add_users.Location = new System.Drawing.Point(12, 256);
            this.btn_add_users.Name = "btn_add_users";
            this.btn_add_users.Size = new System.Drawing.Size(134, 23);
            this.btn_add_users.TabIndex = 1;
            this.btn_add_users.Text = "Добавить";
            this.btn_add_users.UseVisualStyleBackColor = true;
            this.btn_add_users.Click += new System.EventHandler(this.btn_add_users_Click);
            // 
            // btn_delete_users
            // 
            this.btn_delete_users.Location = new System.Drawing.Point(323, 255);
            this.btn_delete_users.Name = "btn_delete_users";
            this.btn_delete_users.Size = new System.Drawing.Size(175, 23);
            this.btn_delete_users.TabIndex = 2;
            this.btn_delete_users.Text = "Удалить";
            this.btn_delete_users.UseVisualStyleBackColor = true;
            this.btn_delete_users.Click += new System.EventHandler(this.btn_delete_users_Click);
            // 
            // gp_dannye
            // 
            this.gp_dannye.Controls.Add(this.btn_changerole);
            this.gp_dannye.Controls.Add(this.cb_roles);
            this.gp_dannye.Controls.Add(this.label7);
            this.gp_dannye.Controls.Add(this.tb_adress_users);
            this.gp_dannye.Controls.Add(this.label6);
            this.gp_dannye.Controls.Add(this.tb_phone);
            this.gp_dannye.Controls.Add(this.label5);
            this.gp_dannye.Controls.Add(this.dtp_date);
            this.gp_dannye.Controls.Add(this.label4);
            this.gp_dannye.Controls.Add(this.tb_fm_users);
            this.gp_dannye.Controls.Add(this.label3);
            this.gp_dannye.Controls.Add(this.tb_otchestvo_users);
            this.gp_dannye.Controls.Add(this.label2);
            this.gp_dannye.Controls.Add(this.tb_name);
            this.gp_dannye.Controls.Add(this.label1);
            this.gp_dannye.Location = new System.Drawing.Point(588, 35);
            this.gp_dannye.Name = "gp_dannye";
            this.gp_dannye.Size = new System.Drawing.Size(344, 366);
            this.gp_dannye.TabIndex = 3;
            this.gp_dannye.TabStop = false;
            this.gp_dannye.Text = "Данные пользователя";
            // 
            // btn_changerole
            // 
            this.btn_changerole.Location = new System.Drawing.Point(144, 327);
            this.btn_changerole.Name = "btn_changerole";
            this.btn_changerole.Size = new System.Drawing.Size(110, 23);
            this.btn_changerole.TabIndex = 14;
            this.btn_changerole.Text = "Сменить роль";
            this.btn_changerole.UseVisualStyleBackColor = true;
            this.btn_changerole.Click += new System.EventHandler(this.btn_changerole_Click);
            // 
            // cb_roles
            // 
            this.cb_roles.FormattingEnabled = true;
            this.cb_roles.Location = new System.Drawing.Point(120, 296);
            this.cb_roles.Name = "cb_roles";
            this.cb_roles.Size = new System.Drawing.Size(200, 24);
            this.cb_roles.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Роль";
            // 
            // tb_adress_users
            // 
            this.tb_adress_users.Enabled = false;
            this.tb_adress_users.Location = new System.Drawing.Point(120, 253);
            this.tb_adress_users.Name = "tb_adress_users";
            this.tb_adress_users.Size = new System.Drawing.Size(200, 22);
            this.tb_adress_users.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес";
            // 
            // tb_phone
            // 
            this.tb_phone.Enabled = false;
            this.tb_phone.Location = new System.Drawing.Point(120, 206);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(200, 22);
            this.tb_phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // dtp_date
            // 
            this.dtp_date.Enabled = false;
            this.dtp_date.Location = new System.Drawing.Point(120, 170);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 22);
            this.dtp_date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // tb_fm_users
            // 
            this.tb_fm_users.Enabled = false;
            this.tb_fm_users.Location = new System.Drawing.Point(117, 130);
            this.tb_fm_users.Name = "tb_fm_users";
            this.tb_fm_users.Size = new System.Drawing.Size(203, 22);
            this.tb_fm_users.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // tb_otchestvo_users
            // 
            this.tb_otchestvo_users.Enabled = false;
            this.tb_otchestvo_users.Location = new System.Drawing.Point(117, 80);
            this.tb_otchestvo_users.Name = "tb_otchestvo_users";
            this.tb_otchestvo_users.Size = new System.Drawing.Size(203, 22);
            this.tb_otchestvo_users.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отчество";
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Location = new System.Drawing.Point(117, 33);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(203, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.gp_dannye);
            this.Controls.Add(this.btn_delete_users);
            this.Controls.Add(this.btn_add_users);
            this.Controls.Add(this.dgv_users);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.gp_dannye.ResumeLayout(false);
            this.gp_dannye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_add_users;
        private System.Windows.Forms.Button btn_delete_users;
        private System.Windows.Forms.GroupBox gp_dannye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_otchestvo_users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fm_users;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_changerole;
        private System.Windows.Forms.ComboBox cb_roles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_adress_users;
        private System.Windows.Forms.Label label6;
    }
}