namespace TI
{
    partial class Lab_2
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
            this.PublicKey = new System.Windows.Forms.TextBox();
            this.PrivateKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PublicKey
            // 
            this.PublicKey.Location = new System.Drawing.Point(2, 26);
            this.PublicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublicKey.Name = "PublicKey";
            this.PublicKey.Size = new System.Drawing.Size(229, 22);
            this.PublicKey.TabIndex = 0;
            // 
            // PrivateKey
            // 
            this.PrivateKey.Location = new System.Drawing.Point(2, 75);
            this.PrivateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(229, 22);
            this.PrivateKey.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(267, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(2, 124);
            this.text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(228, 30);
            this.text.TabIndex = 3;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(2, 183);
            this.encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encrypt.Multiline = true;
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(228, 131);
            this.encrypt.TabIndex = 4;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(2, 340);
            this.decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decrypt.Multiline = true;
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(228, 74);
            this.decrypt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(248, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Location = new System.Drawing.Point(235, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Расшифровать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Открытый ключ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Секретный ключ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Исходный текст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зашифрованный текст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Расшифрованный текст:";
            // 
            // Lab_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(378, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.PublicKey);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PublicKey;
        private System.Windows.Forms.TextBox PrivateKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox encrypt;
        private System.Windows.Forms.TextBox decrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

