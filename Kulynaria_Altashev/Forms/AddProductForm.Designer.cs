namespace Kulynaria_Altashev.Forms
{
    partial class AddProductForm
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
            this.tb_nameBludo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_belki = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zhire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_uglev = new System.Windows.Forms.TextBox();
            this.btn_newProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tb_nameBludo
            // 
            this.tb_nameBludo.Location = new System.Drawing.Point(244, 130);
            this.tb_nameBludo.Name = "tb_nameBludo";
            this.tb_nameBludo.Size = new System.Drawing.Size(100, 20);
            this.tb_nameBludo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Белки";
            // 
            // tb_belki
            // 
            this.tb_belki.Location = new System.Drawing.Point(244, 182);
            this.tb_belki.Name = "tb_belki";
            this.tb_belki.Size = new System.Drawing.Size(100, 20);
            this.tb_belki.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жиры";
            // 
            // tb_zhire
            // 
            this.tb_zhire.Location = new System.Drawing.Point(244, 238);
            this.tb_zhire.Name = "tb_zhire";
            this.tb_zhire.Size = new System.Drawing.Size(100, 20);
            this.tb_zhire.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Углеводы";
            // 
            // tb_uglev
            // 
            this.tb_uglev.Location = new System.Drawing.Point(244, 293);
            this.tb_uglev.Name = "tb_uglev";
            this.tb_uglev.Size = new System.Drawing.Size(100, 20);
            this.tb_uglev.TabIndex = 7;
            // 
            // btn_newProduct
            // 
            this.btn_newProduct.Location = new System.Drawing.Point(340, 362);
            this.btn_newProduct.Name = "btn_newProduct";
            this.btn_newProduct.Size = new System.Drawing.Size(102, 37);
            this.btn_newProduct.TabIndex = 8;
            this.btn_newProduct.Text = "Добавить";
            this.btn_newProduct.UseVisualStyleBackColor = true;
            this.btn_newProduct.Click += new System.EventHandler(this.btn_newProduct_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_newProduct);
            this.Controls.Add(this.tb_uglev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_zhire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_belki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nameBludo);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nameBludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_belki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zhire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_uglev;
        private System.Windows.Forms.Button btn_newProduct;
    }
}