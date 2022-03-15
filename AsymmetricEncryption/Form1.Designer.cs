
namespace AsymmetricEncryption
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InitAlgMe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 15);
            this.label1.MinimumSize = new System.Drawing.Size(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Я";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(567, 15);
            this.label2.MinimumSize = new System.Drawing.Size(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сосед";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InitAlgMe
            // 
            this.InitAlgMe.Location = new System.Drawing.Point(87, 56);
            this.InitAlgMe.Name = "InitAlgMe";
            this.InitAlgMe.Size = new System.Drawing.Size(150, 27);
            this.InitAlgMe.TabIndex = 3;
            this.InitAlgMe.Text = "Init RSA Alg";
            this.InitAlgMe.UseVisualStyleBackColor = true;
            this.InitAlgMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save private key XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save public key XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "Read public key";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(528, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Encrypt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(447, 355);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 83);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 355);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(315, 83);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Encrypted data";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Decrypted data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Original data";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(447, 181);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(315, 83);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(528, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 42);
            this.button6.TabIndex = 16;
            this.button6.Text = "Read file content";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "To decrypt";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(12, 181);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(315, 83);
            this.richTextBox4.TabIndex = 17;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InitAlgMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InitAlgMe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}

