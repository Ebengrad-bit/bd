namespace bd
{
    partial class AbForm
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
            this.Name_ = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_
            // 
            this.Name_.Location = new System.Drawing.Point(12, 12);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(325, 20);
            this.Name_.TabIndex = 0;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(12, 38);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(325, 20);
            this.sName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(12, 64);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(325, 20);
            this.tName.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(12, 90);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(325, 20);
            this.Address.TabIndex = 4;
            // 
            // Birthday
            // 
            this.Birthday.ForeColor = System.Drawing.Color.Black;
            this.Birthday.Location = new System.Drawing.Point(12, 116);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(325, 20);
            this.Birthday.TabIndex = 5;
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(12, 142);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(325, 20);
            this.Comment.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата Рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Комментарий";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "esc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.Name_);
            this.Name = "AbForm";
            this.Text = "AbForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Name_;
        public System.Windows.Forms.TextBox sName;
        public System.Windows.Forms.TextBox tName;
        public System.Windows.Forms.TextBox Address;
        public System.Windows.Forms.TextBox Birthday;
        public System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}