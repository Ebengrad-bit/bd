namespace bd
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab_Main_Plase = new System.Windows.Forms.TabControl();
            this.tab_contat = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgrv_contact = new System.Windows.Forms.DataGridView();
            this.tab_phone = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgrv_phone = new System.Windows.Forms.DataGridView();
            this.tab_provider = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgrv_provider = new System.Windows.Forms.DataGridView();
            this.tab_phone_list = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dgrv_phone_list = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.Tab_Main_Plase.SuspendLayout();
            this.tab_contat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_contact)).BeginInit();
            this.tab_phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_phone)).BeginInit();
            this.tab_provider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_provider)).BeginInit();
            this.tab_phone_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_phone_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Main_Plase
            // 
            this.Tab_Main_Plase.Controls.Add(this.tab_contat);
            this.Tab_Main_Plase.Controls.Add(this.tab_phone);
            this.Tab_Main_Plase.Controls.Add(this.tab_provider);
            this.Tab_Main_Plase.Controls.Add(this.tab_phone_list);
            this.Tab_Main_Plase.Location = new System.Drawing.Point(2, 3);
            this.Tab_Main_Plase.Name = "Tab_Main_Plase";
            this.Tab_Main_Plase.SelectedIndex = 0;
            this.Tab_Main_Plase.Size = new System.Drawing.Size(784, 512);
            this.Tab_Main_Plase.TabIndex = 0;
            // 
            // tab_contat
            // 
            this.tab_contat.Controls.Add(this.button3);
            this.tab_contat.Controls.Add(this.button2);
            this.tab_contat.Controls.Add(this.button1);
            this.tab_contat.Controls.Add(this.dgrv_contact);
            this.tab_contat.Location = new System.Drawing.Point(4, 22);
            this.tab_contat.Name = "tab_contat";
            this.tab_contat.Padding = new System.Windows.Forms.Padding(3);
            this.tab_contat.Size = new System.Drawing.Size(776, 486);
            this.tab_contat.TabIndex = 0;
            this.tab_contat.Text = "Контакты";
            this.tab_contat.UseVisualStyleBackColor = true;
            this.tab_contat.Click += new System.EventHandler(this.tab_contat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgrv_contact
            // 
            this.dgrv_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_contact.Location = new System.Drawing.Point(3, 3);
            this.dgrv_contact.Name = "dgrv_contact";
            this.dgrv_contact.Size = new System.Drawing.Size(770, 399);
            this.dgrv_contact.TabIndex = 0;
            // 
            // tab_phone
            // 
            this.tab_phone.Controls.Add(this.button9);
            this.tab_phone.Controls.Add(this.button8);
            this.tab_phone.Controls.Add(this.button7);
            this.tab_phone.Controls.Add(this.dgrv_phone);
            this.tab_phone.Location = new System.Drawing.Point(4, 22);
            this.tab_phone.Name = "tab_phone";
            this.tab_phone.Padding = new System.Windows.Forms.Padding(3);
            this.tab_phone.Size = new System.Drawing.Size(776, 486);
            this.tab_phone.TabIndex = 1;
            this.tab_phone.Text = "Телефоны";
            this.tab_phone.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 441);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Изменить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(87, 412);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgrv_phone
            // 
            this.dgrv_phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_phone.Location = new System.Drawing.Point(6, 3);
            this.dgrv_phone.Name = "dgrv_phone";
            this.dgrv_phone.Size = new System.Drawing.Size(764, 403);
            this.dgrv_phone.TabIndex = 0;
            // 
            // tab_provider
            // 
            this.tab_provider.Controls.Add(this.button6);
            this.tab_provider.Controls.Add(this.button5);
            this.tab_provider.Controls.Add(this.button4);
            this.tab_provider.Controls.Add(this.dgrv_provider);
            this.tab_provider.Location = new System.Drawing.Point(4, 22);
            this.tab_provider.Name = "tab_provider";
            this.tab_provider.Size = new System.Drawing.Size(776, 486);
            this.tab_provider.TabIndex = 2;
            this.tab_provider.Text = "Провайдеры";
            this.tab_provider.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 454);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dgrv_provider
            // 
            this.dgrv_provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_provider.Location = new System.Drawing.Point(6, 3);
            this.dgrv_provider.Name = "dgrv_provider";
            this.dgrv_provider.Size = new System.Drawing.Size(767, 416);
            this.dgrv_provider.TabIndex = 0;
            // 
            // tab_phone_list
            // 
            this.tab_phone_list.Controls.Add(this.button12);
            this.tab_phone_list.Controls.Add(this.button11);
            this.tab_phone_list.Controls.Add(this.button10);
            this.tab_phone_list.Controls.Add(this.dgrv_phone_list);
            this.tab_phone_list.Location = new System.Drawing.Point(4, 22);
            this.tab_phone_list.Name = "tab_phone_list";
            this.tab_phone_list.Size = new System.Drawing.Size(776, 486);
            this.tab_phone_list.TabIndex = 3;
            this.tab_phone_list.Text = "Тел. Справочник";
            this.tab_phone_list.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(87, 440);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "Удалить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 440);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "Добавить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgrv_phone_list
            // 
            this.dgrv_phone_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_phone_list.Location = new System.Drawing.Point(6, 3);
            this.dgrv_phone_list.Name = "dgrv_phone_list";
            this.dgrv_phone_list.Size = new System.Drawing.Size(767, 431);
            this.dgrv_phone_list.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 521);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(369, 554);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 460);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Изменить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 586);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tab_Main_Plase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab_Main_Plase.ResumeLayout(false);
            this.tab_contat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_contact)).EndInit();
            this.tab_phone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_phone)).EndInit();
            this.tab_provider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_provider)).EndInit();
            this.tab_phone_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_phone_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         
        private System.Windows.Forms.TabControl Tab_Main_Plase;
        private System.Windows.Forms.TabPage tab_contat;
        private System.Windows.Forms.TabPage tab_phone;
        private System.Windows.Forms.TabPage tab_provider;
        private System.Windows.Forms.TabPage tab_phone_list;
        private System.Windows.Forms.DataGridView dgrv_contact;
        private System.Windows.Forms.DataGridView dgrv_phone;
        private System.Windows.Forms.DataGridView dgrv_provider;
        private System.Windows.Forms.DataGridView dgrv_phone_list;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

