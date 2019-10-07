namespace WindowsFormsApp1
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnzigzag = new System.Windows.Forms.Button();
            this.txtZigzag = new System.Windows.Forms.TextBox();
            this.txtMultiplicationNumber = new System.Windows.Forms.TextBox();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.txtFibonacciResult = new System.Windows.Forms.TextBox();
            this.btnFibonacciResult = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(64, 56);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(213, 22);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(64, 99);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(213, 22);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(64, 141);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(213, 22);
            this.txtNumber3.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(64, 190);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(213, 22);
            this.txtResult.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(64, 233);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(213, 61);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Sonucu Göster";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnzigzag
            // 
            this.btnzigzag.Location = new System.Drawing.Point(601, 326);
            this.btnzigzag.Name = "btnzigzag";
            this.btnzigzag.Size = new System.Drawing.Size(213, 61);
            this.btnzigzag.TabIndex = 7;
            this.btnzigzag.Text = "Sonucu Göster";
            this.btnzigzag.UseVisualStyleBackColor = true;
            this.btnzigzag.Click += new System.EventHandler(this.Btnzigzag_Click);
            // 
            // txtZigzag
            // 
            this.txtZigzag.Location = new System.Drawing.Point(439, 23);
            this.txtZigzag.Multiline = true;
            this.txtZigzag.Name = "txtZigzag";
            this.txtZigzag.Size = new System.Drawing.Size(539, 271);
            this.txtZigzag.TabIndex = 8;
            // 
            // txtMultiplicationNumber
            // 
            this.txtMultiplicationNumber.Location = new System.Drawing.Point(12, 423);
            this.txtMultiplicationNumber.Name = "txtMultiplicationNumber";
            this.txtMultiplicationNumber.Size = new System.Drawing.Size(226, 22);
            this.txtMultiplicationNumber.TabIndex = 9;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(12, 755);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(213, 61);
            this.btnMultiplication.TabIndex = 11;
            this.btnMultiplication.Text = "Sonucu Göster";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.BtnMultiplication_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 467);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(942, 260);
            this.listBox1.TabIndex = 12;
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Location = new System.Drawing.Point(1044, 569);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(160, 22);
            this.txtFibonacci.TabIndex = 13;
            // 
            // txtFibonacciResult
            // 
            this.txtFibonacciResult.Location = new System.Drawing.Point(1044, 611);
            this.txtFibonacciResult.Name = "txtFibonacciResult";
            this.txtFibonacciResult.Size = new System.Drawing.Size(160, 22);
            this.txtFibonacciResult.TabIndex = 14;
            // 
            // btnFibonacciResult
            // 
            this.btnFibonacciResult.Location = new System.Drawing.Point(1044, 676);
            this.btnFibonacciResult.Name = "btnFibonacciResult";
            this.btnFibonacciResult.Size = new System.Drawing.Size(165, 51);
            this.btnFibonacciResult.TabIndex = 15;
            this.btnFibonacciResult.Text = "Fibonacci Bul";
            this.btnFibonacciResult.UseVisualStyleBackColor = true;
            this.btnFibonacciResult.Click += new System.EventHandler(this.BtnFibonacciResult_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1120, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 280);
            this.textBox2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1254, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 66);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dosya Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "test1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "test2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "test3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1059, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "test5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1041, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "test4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1659, 1055);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnFibonacciResult);
            this.Controls.Add(this.txtFibonacciResult);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.txtMultiplicationNumber);
            this.Controls.Add(this.txtZigzag);
            this.Controls.Add(this.btnzigzag);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnzigzag;
        private System.Windows.Forms.TextBox txtZigzag;
        private System.Windows.Forms.TextBox txtMultiplicationNumber;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.TextBox txtFibonacciResult;
        private System.Windows.Forms.Button btnFibonacciResult;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

