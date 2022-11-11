namespace DollarToBath_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dollar_textBox = new System.Windows.Forms.TextBox();
            this.baht_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.Cur_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมคำนวนอัตราแลกเปลี่ยนระหว่าง\r\nเงินบาทกับดอลลาร์สหรัฐ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 126);
            this.label2.TabIndex = 2;
            this.label2.Text = "อิงตาม ณ วันที่ 11/11/2022 อัตราแลกปลี่ยนอยู่ที่ \r\n1 ดอลลาร์สหรัฐ (USD) = 35.97 บ" +
    "าท (THB)\r\n1 บาท (THB) = 0.028 ดอลลาร์สหรัฐ (USD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "ดอลลาร์สหรัฐ (USD)";
            // 
            // dollar_textBox
            // 
            this.dollar_textBox.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollar_textBox.Location = new System.Drawing.Point(57, 170);
            this.dollar_textBox.Name = "dollar_textBox";
            this.dollar_textBox.Size = new System.Drawing.Size(200, 43);
            this.dollar_textBox.TabIndex = 4;
            this.dollar_textBox.Text = "1";
            this.dollar_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update_Data);
            // 
            // baht_textBox
            // 
            this.baht_textBox.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baht_textBox.Location = new System.Drawing.Point(57, 244);
            this.baht_textBox.Name = "baht_textBox";
            this.baht_textBox.Size = new System.Drawing.Size(200, 43);
            this.baht_textBox.TabIndex = 5;
            this.baht_textBox.Text = "35.97";
            this.baht_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.update_Data);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "บาท (THB)";
            // 
            // currency
            // 
            this.currency.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency.ForeColor = System.Drawing.Color.White;
            this.currency.Location = new System.Drawing.Point(50, 115);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(474, 40);
            this.currency.TabIndex = 7;
            this.currency.Text = "อัตราแลกเปลี่ยน : 35.97 THB / 1 USD";
            // 
            // Cur_textBox
            // 
            this.Cur_textBox.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cur_textBox.Location = new System.Drawing.Point(533, 203);
            this.Cur_textBox.Name = "Cur_textBox";
            this.Cur_textBox.Size = new System.Drawing.Size(114, 43);
            this.Cur_textBox.TabIndex = 8;
            this.Cur_textBox.Text = "35.97";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(526, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "กำหนดอัตราแลกเปลี่ยน";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(594, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "อัพเดท";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(653, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "THB / 1 USD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DollarToBath_Project.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(57, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cur_textBox);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.baht_textBox);
            this.Controls.Add(this.dollar_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chatnarint_DollarToBath";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dollar_textBox;
        private System.Windows.Forms.TextBox baht_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.TextBox Cur_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

