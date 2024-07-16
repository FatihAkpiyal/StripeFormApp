namespace Stripe_FormApp
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
            panel1 = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            textBox12 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            txtCardToken = new TextBox();
            txtExpMonth = new TextBox();
            txtCvc = new TextBox();
            label10 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            panel3 = new Panel();
            txtExpYear = new TextBox();
            lblStatus = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(13, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 337);
            panel2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(27, 218);
            label11.Name = "label11";
            label11.Size = new Size(123, 18);
            label11.TabIndex = 12;
            label11.Text = "Billing Adress";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(27, 239);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "United States";
            textBox12.Size = new Size(209, 23);
            textBox12.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 149);
            label4.Name = "label4";
            label4.Size = new Size(139, 18);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 102);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 9;
            label3.Text = "Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 170);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "+90 555 555 55 55";
            textBox4.Size = new Size(209, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 123);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "stripe@gmail.com";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stripe;
            pictureBox1.Location = new Point(71, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            label9.Location = new Point(0, 14);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 9;
            label9.Text = "Payment Details";
            // 
            // txtCardToken
            // 
            txtCardToken.Location = new Point(0, 89);
            txtCardToken.Name = "txtCardToken";
            txtCardToken.PlaceholderText = "1234 1234 1234 1234";
            txtCardToken.Size = new Size(209, 23);
            txtCardToken.TabIndex = 10;
            // 
            // txtExpMonth
            // 
            txtExpMonth.Location = new Point(0, 113);
            txtExpMonth.Name = "txtExpMonth";
            txtExpMonth.PlaceholderText = "MM/YY";
            txtExpMonth.Size = new Size(37, 23);
            txtExpMonth.TabIndex = 11;
            // 
            // txtCvc
            // 
            txtCvc.Location = new Point(92, 113);
            txtCvc.Name = "txtCvc";
            txtCvc.PlaceholderText = "CVC";
            txtCvc.Size = new Size(117, 23);
            txtCvc.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            label10.Location = new Point(0, 60);
            label10.Name = "label10";
            label10.Size = new Size(141, 23);
            label10.TabIndex = 13;
            label10.Text = "Card Information";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(203, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Billing adress is same as shipping.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 402);
            button2.Name = "button2";
            button2.Size = new Size(800, 48);
            button2.TabIndex = 15;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtExpYear);
            panel3.Controls.Add(txtCardToken);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(txtExpMonth);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtCvc);
            panel3.Location = new Point(528, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 405);
            panel3.TabIndex = 16;
            // 
            // txtExpYear
            // 
            txtExpYear.Location = new Point(40, 113);
            txtExpYear.Name = "txtExpYear";
            txtExpYear.PlaceholderText = "MM/YY";
            txtExpYear.Size = new Size(37, 23);
            txtExpYear.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(292, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(230, 367);
            lblStatus.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Fast Payment";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label9;
        private TextBox txtCardToken;
        private TextBox txtExpMonth;
        private TextBox txtCvc;
        private Label label10;
        private CheckBox checkBox1;
        private Label label11;
        private TextBox textBox12;
        private Button button2;
        private Panel panel3;
        private Label lblStatus;
        private TextBox txtExpYear;
    }
}
