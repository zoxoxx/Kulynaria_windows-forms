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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПродуктToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox_SostavBluda = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Картинка = new System.Windows.Forms.DataGridViewImageColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Категория = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Основа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_bludoName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_counter = new System.Windows.Forms.Label();
            this.gb_sostav = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_sostav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem,
            this.продуктToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.fIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрБлюдToolStripMenuItem,
            this.добавитьБлюдоToolStripMenuItem,
            this.удалитьБлюдоToolStripMenuItem,
            this.поискПоКритериямToolStripMenuItem});
            this.блюдаToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.dish;
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            // 
            // просмотрБлюдToolStripMenuItem
            // 
            this.просмотрБлюдToolStripMenuItem.Name = "просмотрБлюдToolStripMenuItem";
            this.просмотрБлюдToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.просмотрБлюдToolStripMenuItem.Text = "Просмотр блюд";
            // 
            // добавитьБлюдоToolStripMenuItem
            // 
            this.добавитьБлюдоToolStripMenuItem.Name = "добавитьБлюдоToolStripMenuItem";
            this.добавитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.добавитьБлюдоToolStripMenuItem.Text = "Добавить блюдо";
            this.добавитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.добавитьБлюдоToolStripMenuItem_Click);
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            // 
            // поискПоКритериямToolStripMenuItem
            // 
            this.поискПоКритериямToolStripMenuItem.Name = "поискПоКритериямToolStripMenuItem";
            this.поискПоКритериямToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.поискПоКритериямToolStripMenuItem.Text = "Поиск по критериям";
            this.поискПоКритериямToolStripMenuItem.Click += new System.EventHandler(this.поискПоКритериямToolStripMenuItem_Click);
            // 
            // продуктToolStripMenuItem
            // 
            this.продуктToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПродуктToolStripMenuItem,
            this.иToolStripMenuItem});
            this.продуктToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.diet;
            this.продуктToolStripMenuItem.Name = "продуктToolStripMenuItem";
            this.продуктToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.продуктToolStripMenuItem.Text = "Продукт";
            // 
            // добавитьПродуктToolStripMenuItem
            // 
            this.добавитьПродуктToolStripMenuItem.Name = "добавитьПродуктToolStripMenuItem";
            this.добавитьПродуктToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.добавитьПродуктToolStripMenuItem.Text = "Добавить продукт";
            this.добавитьПродуктToolStripMenuItem.Click += new System.EventHandler(this.добавитьПродуктToolStripMenuItem_Click);
            // 
            // иToolStripMenuItem
            // 
            this.иToolStripMenuItem.Name = "иToolStripMenuItem";
            this.иToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.иToolStripMenuItem.Text = "Поиск и удаление продуктов";
            this.иToolStripMenuItem.Click += new System.EventHandler(this.иToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рецептыToolStripMenuItem});
            this.рецептToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.recipe;
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.рецептыToolStripMenuItem_Click);
            // 
            // fIOToolStripMenuItem
            // 
            this.fIOToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПрофильToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.fIOToolStripMenuItem.Image = global::Kulynaria_Altashev.Properties.Resources.profil;
            this.fIOToolStripMenuItem.Name = "fIOToolStripMenuItem";
            this.fIOToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fIOToolStripMenuItem.Text = "FIO";
            this.fIOToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // редактироватьПрофильToolStripMenuItem
            // 
            this.редактироватьПрофильToolStripMenuItem.Name = "редактироватьПрофильToolStripMenuItem";
            this.редактироватьПрофильToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.редактироватьПрофильToolStripMenuItem.Text = "Редактировать профиль";
            this.редактироватьПрофильToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПрофильToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(468, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск блюда";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(663, 166);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox_SostavBluda
            // 
            this.listBox_SostavBluda.FormattingEnabled = true;
            this.listBox_SostavBluda.ItemHeight = 16;
            this.listBox_SostavBluda.Location = new System.Drawing.Point(12, 22);
            this.listBox_SostavBluda.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_SostavBluda.Name = "listBox_SostavBluda";
            this.listBox_SostavBluda.Size = new System.Drawing.Size(188, 228);
            this.listBox_SostavBluda.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(155, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(652, 315);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Картинка
            // 
            this.Картинка.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Картинка.HeaderText = "Картинка";
            this.Картинка.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Картинка.MinimumWidth = 6;
            this.Картинка.Name = "Картинка";
            this.Картинка.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Картинка.Width = 125;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.MinimumWidth = 6;
            this.Название.Name = "Название";
            this.Название.Width = 125;
            // 
            // Категория
            // 
            this.Категория.HeaderText = "Категория";
            this.Категория.MinimumWidth = 6;
            this.Категория.Name = "Категория";
            this.Категория.Width = 125;
            // 
            // Основа
            // 
            this.Основа.HeaderText = "Основа";
            this.Основа.MinimumWidth = 6;
            this.Основа.Name = "Основа";
            this.Основа.Width = 125;
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.MinimumWidth = 6;
            this.Вес.Name = "Вес";
            this.Вес.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, -1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Состав блюда";
            // 
            // lbl_bludoName
            // 
            this.lbl_bludoName.AutoSize = true;
            this.lbl_bludoName.Location = new System.Drawing.Point(129, 0);
            this.lbl_bludoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bludoName.Name = "lbl_bludoName";
            this.lbl_bludoName.Size = new System.Drawing.Size(83, 16);
            this.lbl_bludoName.TabIndex = 9;
            this.lbl_bludoName.Text = "Имя_Блюда";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_counter
            // 
            this.lb_counter.AutoSize = true;
            this.lb_counter.Location = new System.Drawing.Point(663, 198);
            this.lb_counter.Name = "lb_counter";
            this.lb_counter.Size = new System.Drawing.Size(11, 16);
            this.lb_counter.TabIndex = 10;
            this.lb_counter.Text = "/";
            // 
            // gb_sostav
            // 
            this.gb_sostav.Controls.Add(this.listBox_SostavBluda);
            this.gb_sostav.Controls.Add(this.label4);
            this.gb_sostav.Controls.Add(this.lbl_bludoName);
            this.gb_sostav.Location = new System.Drawing.Point(833, 215);
            this.gb_sostav.Name = "gb_sostav";
            this.gb_sostav.Size = new System.Drawing.Size(222, 327);
            this.gb_sostav.TabIndex = 11;
            this.gb_sostav.TabStop = false;
            this.gb_sostav.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gb_sostav);
            this.Controls.Add(this.lb_counter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ООО \"Вкусно и полезно\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_sostav.ResumeLayout(false);
            this.gb_sostav.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox_SostavBluda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Картинка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Категория;
        private System.Windows.Forms.DataGridViewTextBoxColumn Основа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
        private System.Windows.Forms.Label lbl_bludoName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПродуктToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоКритериямToolStripMenuItem;
        private System.Windows.Forms.Label lb_counter;
        private System.Windows.Forms.GroupBox gb_sostav;
    }
}

