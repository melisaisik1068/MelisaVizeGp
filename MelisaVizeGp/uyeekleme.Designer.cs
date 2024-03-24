namespace MelisaVizeGp
{
    partial class uyeekleme
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
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 144);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 183);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(450, 116);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 251);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Cep Telefonu";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 215);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 4;
            label4.Text = "T.C Kimlik Numarası";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 54);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 5;
            label5.Text = "Üye Ekleme Formu";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(273, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 27);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 287);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 10;
            label6.Text = "Üyelik Tarihi";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(249, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // uyeekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "uyeekleme";
            Text = "üyeekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
    }
}