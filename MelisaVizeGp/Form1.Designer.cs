﻿namespace MelisaVizeGp
{
    partial class Form1
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(120, 154);
            button1.Name = "button1";
            button1.Size = new Size(556, 52);
            button1.TabIndex = 0;
            button1.Text = "Üye Ekleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(120, 238);
            button2.Name = "button2";
            button2.Size = new Size(556, 52);
            button2.TabIndex = 1;
            button2.Text = "Kitap Ekleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(120, 319);
            button3.Name = "button3";
            button3.Size = new Size(556, 52);
            button3.TabIndex = 2;
            button3.Text = "Emanet İşlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 87);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 3;
            label1.Text = "Kütüphane Kitap Takip Sistemi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 87);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 3;
            label1.Text = "Kütüphane Kitap Takip Sistemi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}