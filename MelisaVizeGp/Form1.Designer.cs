namespace MelisaVizeGp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            uyeeklemebutton = new Button();
            kitapeklemebutton = new Button();
            emanetislembutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 34);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Takip Sistemi";
            label1.Click += label1_Click;
            // 
            // uyeeklemebutton
            // 
            uyeeklemebutton.Location = new Point(118, 118);
            uyeeklemebutton.Name = "uyeeklemebutton";
            uyeeklemebutton.Size = new Size(566, 41);
            uyeeklemebutton.TabIndex = 1;
            uyeeklemebutton.Text = "Üye Ekleme";
            uyeeklemebutton.UseVisualStyleBackColor = true;
            uyeeklemebutton.Click += uyeeklemebutton_Click;
            // 
            // kitapeklemebutton
            // 
            kitapeklemebutton.Location = new Point(118, 192);
            kitapeklemebutton.Name = "kitapeklemebutton";
            kitapeklemebutton.Size = new Size(566, 41);
            kitapeklemebutton.TabIndex = 2;
            kitapeklemebutton.Text = "Kitap Ekleme";
            kitapeklemebutton.UseVisualStyleBackColor = true;
            kitapeklemebutton.Click += kitapeklemebutton_Click;
            // 
            // emanetislembutton
            // 
            emanetislembutton.Location = new Point(118, 257);
            emanetislembutton.Name = "emanetislembutton";
            emanetislembutton.Size = new Size(566, 41);
            emanetislembutton.TabIndex = 3;
            emanetislembutton.Text = "Emanet İşlemleri";
            emanetislembutton.UseVisualStyleBackColor = true;
            emanetislembutton.Click += emanetislembutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emanetislembutton);
            Controls.Add(kitapeklemebutton);
            Controls.Add(uyeeklemebutton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button uyeeklemebutton;
        private Button kitapeklemebutton;
        private Button emanetislembutton;
    }
}
