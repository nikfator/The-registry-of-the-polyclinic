namespace PPTX1
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(228, 36);
            button1.TabIndex = 0;
            button1.Text = "Информация о больном";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(246, 12);
            button2.Name = "button2";
            button2.Size = new Size(228, 36);
            button2.TabIndex = 1;
            button2.Text = "Информация о врачах";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(480, 12);
            button3.Name = "button3";
            button3.Size = new Size(228, 36);
            button3.TabIndex = 2;
            button3.Text = "Регистрация пациента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(714, 12);
            button4.Name = "button4";
            button4.Size = new Size(228, 36);
            button4.TabIndex = 3;
            button4.Text = "Печать документации";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSkyBlue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(593, 411);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = Properties.Resources.Main2;
            label1.Location = new Point(611, 100);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 5;
            label1.Text = "Введите ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = Properties.Resources.Main2;
            label2.Location = new Point(611, 129);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 6;
            label2.Text = "Введите СНИЛС";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Image = Properties.Resources.Main2;
            label3.Location = new Point(761, 164);
            label3.Name = "label3";
            label3.Size = new Size(180, 21);
            label3.TabIndex = 7;
            label3.Text = "ФИО лечащего врача";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = Properties.Resources.Main2;
            label4.Location = new Point(714, 199);
            label4.Name = "label4";
            label4.Size = new Size(233, 21);
            label4.TabIndex = 8;
            label4.Text = "№ кабинета лечащего врача";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(816, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(816, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 23);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Image = Properties.Resources.Main2;
            label5.Location = new Point(23, 65);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 11;
            label5.Text = "Снилс больного";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Properties.Resources.Main2;
            label6.Location = new Point(135, 65);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 12;
            label6.Text = "ФИО больного";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Image = Properties.Resources.Main2;
            label7.Location = new Point(269, 65);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 13;
            label7.Text = "Адрес";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Image = Properties.Resources.Main2;
            label8.Location = new Point(353, 65);
            label8.Name = "label8";
            label8.Size = new Size(111, 17);
            label8.TabIndex = 14;
            label8.Text = "Дата обращения";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Image = Properties.Resources.Main2;
            label9.Location = new Point(491, 65);
            label9.Name = "label9";
            label9.Size = new Size(95, 17);
            label9.TabIndex = 15;
            label9.Text = "Дата выписки";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightSkyBlue;
            textBox4.Enabled = false;
            textBox4.Location = new Point(131, 53);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(5, 411);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightSkyBlue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(247, 53);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(5, 411);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSkyBlue;
            textBox6.Enabled = false;
            textBox6.Location = new Point(337, 53);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(5, 411);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightSkyBlue;
            textBox7.Enabled = false;
            textBox7.Location = new Point(474, 53);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(5, 411);
            textBox7.TabIndex = 19;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Main2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(953, 469);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}