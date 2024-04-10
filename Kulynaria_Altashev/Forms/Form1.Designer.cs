namespace Kulynaria_Altashev.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Картинка = new System.Windows.Forms.DataGridViewImageColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Основа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem,
            this.продуктToolStripMenuItem,
            this.рецептToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрБлюдToolStripMenuItem,
            this.добавитьБлюдоToolStripMenuItem,
            this.удалитьБлюдоToolStripMenuItem});
            this.блюдаToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.dish;
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            // 
            // просмотрБлюдToolStripMenuItem
            // 
            this.просмотрБлюдToolStripMenuItem.Name = "просмотрБлюдToolStripMenuItem";
            this.просмотрБлюдToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.просмотрБлюдToolStripMenuItem.Text = "Просмотр блюд";
            // 
            // добавитьБлюдоToolStripMenuItem
            // 
            this.добавитьБлюдоToolStripMenuItem.Name = "добавитьБлюдоToolStripMenuItem";
            this.добавитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьБлюдоToolStripMenuItem.Text = "Добавить блюдо";
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.diet;
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.recipe;
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(351, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск блюда";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(497, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(632, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 186);
            this.listBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Картинка,
            this.Название,
            this.Категория,
            this.Основа,
            this.Вес});
            this.dataGridView1.Location = new System.Drawing.Point(116, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 256);
            this.dataGridView1.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Картинка
            // 
            this.Картинка.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Картинка.HeaderText = "Картинка";
            this.Картинка.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Картинка.Name = "Картинка";
            this.Картинка.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            // 
            // Категория
            // 
            this.Категория.HeaderText = "Категория";
            this.Категория.Name = "Категория";
            // 
            // Основа
            // 
            this.Основа.HeaderText = "Основа";
            this.Основа.Name = "Основа";
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.Name = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Состав блюда";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ООО \"Вкусно и полезно\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Картинка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
        private System.Windows.Forms.DataGridViewTextBoxColumn Основа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
    }
}

