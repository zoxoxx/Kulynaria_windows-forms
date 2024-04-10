namespace Kulynaria_Altashev.Forms
{
    partial class Delete_SearchForm
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(221, 117);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(132, 22);
            this.tb_search.TabIndex = 0;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_products.Location = new System.Drawing.Point(144, 174);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.Size = new System.Drawing.Size(595, 185);
            this.dgv_products.TabIndex = 2;
            this.dgv_products.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_CellMouseClick);
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
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Белки";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Жиры";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Углеводы";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(831, 239);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(164, 70);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "Добавить продукт";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(221, 394);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(132, 45);
            this.btn_deleteProduct.TabIndex = 4;
            this.btn_deleteProduct.Text = "Удалить продукт";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // Delete_SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Delete_SearchForm";
            this.Text = "Delete_SearchForm";
            this.Load += new System.EventHandler(this.Delete_SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
    }
}