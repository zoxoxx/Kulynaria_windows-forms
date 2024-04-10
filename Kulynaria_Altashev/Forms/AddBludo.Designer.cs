namespace Kulynaria_Altashev.Forms
{
    partial class AddBludo
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
            this.tb_BludoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_kat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ves = new System.Windows.Forms.TextBox();
            this.pbBludo = new System.Windows.Forms.PictureBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWeightProd = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dgvSostavBluda = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmb_osn = new System.Windows.Forms.ComboBox();
            this.Продукт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBludo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSostavBluda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название блюда";
            // 
            // tb_BludoName
            // 
            this.tb_BludoName.Location = new System.Drawing.Point(133, 27);
            this.tb_BludoName.Name = "tb_BludoName";
            this.tb_BludoName.Size = new System.Drawing.Size(259, 20);
            this.tb_BludoName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // cmb_kat
            // 
            this.cmb_kat.FormattingEnabled = true;
            this.cmb_kat.Location = new System.Drawing.Point(133, 70);
            this.cmb_kat.Name = "cmb_kat";
            this.cmb_kat.Size = new System.Drawing.Size(121, 21);
            this.cmb_kat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Основа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вес";
            // 
            // tb_ves
            // 
            this.tb_ves.Location = new System.Drawing.Point(133, 184);
            this.tb_ves.Name = "tb_ves";
            this.tb_ves.Size = new System.Drawing.Size(100, 20);
            this.tb_ves.TabIndex = 7;
            // 
            // pbBludo
            // 
            this.pbBludo.Location = new System.Drawing.Point(510, 27);
            this.pbBludo.Name = "pbBludo";
            this.pbBludo.Size = new System.Drawing.Size(174, 157);
            this.pbBludo.TabIndex = 8;
            this.pbBludo.TabStop = false;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(713, 25);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(75, 23);
            this.btn_choose.TabIndex = 9;
            this.btn_choose.Text = "Выбрать";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Добавить состав блюда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Продукт";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(158, 268);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вес";
            // 
            // tbWeightProd
            // 
            this.tbWeightProd.Location = new System.Drawing.Point(404, 270);
            this.tbWeightProd.Name = "tbWeightProd";
            this.tbWeightProd.Size = new System.Drawing.Size(100, 20);
            this.tbWeightProd.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(602, 301);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(602, 354);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dgvSostavBluda
            // 
            this.dgvSostavBluda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSostavBluda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Продукт,
            this.Вес});
            this.dgvSostavBluda.Location = new System.Drawing.Point(72, 296);
            this.dgvSostavBluda.Name = "dgvSostavBluda";
            this.dgvSostavBluda.Size = new System.Drawing.Size(348, 150);
            this.dgvSostavBluda.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(474, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_osn
            // 
            this.cmb_osn.FormattingEnabled = true;
            this.cmb_osn.Location = new System.Drawing.Point(133, 132);
            this.cmb_osn.Name = "cmb_osn";
            this.cmb_osn.Size = new System.Drawing.Size(121, 21);
            this.cmb_osn.TabIndex = 19;
            // 
            // Продукт
            // 
            this.Продукт.HeaderText = "Продукт";
            this.Продукт.Name = "Продукт";
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.Name = "Вес";
            // 
            // AddBludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_osn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSostavBluda);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbWeightProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.pbBludo);
            this.Controls.Add(this.tb_ves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_kat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_BludoName);
            this.Controls.Add(this.label1);
            this.Name = "AddBludo";
            this.Text = "AddBludo";
            this.Load += new System.EventHandler(this.AddBludo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBludo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSostavBluda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_BludoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_kat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ves;
        private System.Windows.Forms.PictureBox pbBludo;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWeightProd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dgvSostavBluda;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmb_osn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
    }
}