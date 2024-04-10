namespace Kulynaria_Altashev.Forms
{
    partial class ReceptForm
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
            this.ListBox_sostavBl = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_bludoname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_vpered = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.tb_recept = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_sostavBl
            // 
            this.ListBox_sostavBl.FormattingEnabled = true;
            this.ListBox_sostavBl.Location = new System.Drawing.Point(19, 46);
            this.ListBox_sostavBl.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_sostavBl.Name = "ListBox_sostavBl";
            this.ListBox_sostavBl.Size = new System.Drawing.Size(128, 238);
            this.ListBox_sostavBl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Блюдо:";
            // 
            // label_bludoname
            // 
            this.label_bludoname.AutoSize = true;
            this.label_bludoname.Location = new System.Drawing.Point(69, 22);
            this.label_bludoname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bludoname.Name = "label_bludoname";
            this.label_bludoname.Size = new System.Drawing.Size(39, 13);
            this.label_bludoname.TabIndex = 2;
            this.label_bludoname.Text = "блюдо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(233, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Рецепты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBox_sostavBl);
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_vpered);
            this.groupBox2.Controls.Add(this.btn_nazad);
            this.groupBox2.Controls.Add(this.tb_recept);
            this.groupBox2.Location = new System.Drawing.Point(289, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(415, 261);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Способ приготовления";
            // 
            // btn_vpered
            // 
            this.btn_vpered.Location = new System.Drawing.Point(369, 70);
            this.btn_vpered.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vpered.Name = "btn_vpered";
            this.btn_vpered.Size = new System.Drawing.Size(42, 74);
            this.btn_vpered.TabIndex = 2;
            this.btn_vpered.Text = ">";
            this.btn_vpered.UseVisualStyleBackColor = true;
            this.btn_vpered.Click += new System.EventHandler(this.btn_vpered_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(4, 70);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(41, 74);
            this.btn_nazad.TabIndex = 1;
            this.btn_nazad.Text = "<";
            this.btn_nazad.UseVisualStyleBackColor = true;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // tb_recept
            // 
            this.tb_recept.Location = new System.Drawing.Point(56, 34);
            this.tb_recept.Margin = new System.Windows.Forms.Padding(2);
            this.tb_recept.Multiline = true;
            this.tb_recept.Name = "tb_recept";
            this.tb_recept.Size = new System.Drawing.Size(309, 180);
            this.tb_recept.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(410, 37);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(33, 24);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(462, 37);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(35, 24);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(518, 37);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(38, 24);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // ReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 566);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_bludoname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptForm";
            this.Text = "ReceptForm";
            this.Load += new System.EventHandler(this.ReceptForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_sostavBl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bludoname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_recept;
        private System.Windows.Forms.Button btn_vpered;
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
    }
}