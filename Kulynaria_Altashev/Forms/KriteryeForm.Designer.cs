namespace Kulynaria_Altashev.Forms
{
    partial class KriteryeForm
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
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_bluda = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search_on = new System.Windows.Forms.Button();
            this.btn_search_off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bluda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по критерям";
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgv_products.Location = new System.Drawing.Point(34, 123);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(306, 315);
            this.dgv_products.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Продукты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Блюда";
            // 
            // dgv_bluda
            // 
            this.dgv_bluda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bluda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_bluda.Location = new System.Drawing.Point(575, 123);
            this.dgv_bluda.Name = "dgv_bluda";
            this.dgv_bluda.RowHeadersWidth = 51;
            this.dgv_bluda.RowTemplate.Height = 40;
            this.dgv_bluda.Size = new System.Drawing.Size(688, 315);
            this.dgv_bluda.TabIndex = 4;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Включить в поиск";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Изображение";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Категория";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Основа";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Вес";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Белки";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Белки";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Жиры";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Углеводы";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            this.Column13.Width = 125;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1178, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Назад";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_search_on
            // 
            this.btn_search_on.Location = new System.Drawing.Point(172, 477);
            this.btn_search_on.Name = "btn_search_on";
            this.btn_search_on.Size = new System.Drawing.Size(168, 53);
            this.btn_search_on.TabIndex = 6;
            this.btn_search_on.Text = "Поиск включащий выбранные продукты";
            this.btn_search_on.UseVisualStyleBackColor = true;
            this.btn_search_on.Click += new System.EventHandler(this.btn_search_on_Click);
            // 
            // btn_search_off
            // 
            this.btn_search_off.Location = new System.Drawing.Point(575, 477);
            this.btn_search_off.Name = "btn_search_off";
            this.btn_search_off.Size = new System.Drawing.Size(174, 53);
            this.btn_search_off.TabIndex = 7;
            this.btn_search_off.Text = "Поиск, не включающий выбранные продукты";
            this.btn_search_off.UseVisualStyleBackColor = true;
            this.btn_search_off.Click += new System.EventHandler(this.btn_search_off_Click);
            // 
            // KriteryeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 542);
            this.Controls.Add(this.btn_search_off);
            this.Controls.Add(this.btn_search_on);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_bluda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.label1);
            this.Name = "KriteryeForm";
            this.Text = "KriteryeForm";
            this.Load += new System.EventHandler(this.KriteryeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bluda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_bluda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search_on;
        private System.Windows.Forms.Button btn_search_off;
    }
}