namespace Calculator
{
    partial class Calculator
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
            this.equal = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(38, 379);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(716, 44);
            this.equal.TabIndex = 1;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(38, 273);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(126, 47);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(38, 24);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(716, 45);
            this.TextBox.TabIndex = 11;
            this.TextBox.Text = "This is a basic calculator without chaining of operations or something";
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(170, 326);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(126, 47);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(302, 273);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(126, 47);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(38, 220);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(126, 47);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(170, 273);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(126, 47);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(302, 220);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(126, 47);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(38, 165);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(126, 47);
            this.seven.TabIndex = 17;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(170, 220);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(126, 47);
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(302, 165);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(126, 47);
            this.nine.TabIndex = 19;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(628, 167);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(126, 47);
            this.div.TabIndex = 22;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(628, 220);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 47);
            this.add.TabIndex = 23;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(628, 273);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(126, 47);
            this.min.TabIndex = 24;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(628, 326);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(126, 47);
            this.mult.TabIndex = 25;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(170, 165);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(126, 47);
            this.eight.TabIndex = 26;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(302, 326);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(126, 47);
            this.dot.TabIndex = 27;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(38, 326);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(126, 47);
            this.clear.TabIndex = 28;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.min);
            this.Controls.Add(this.add);
            this.Controls.Add(this.div);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.five);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.two);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button clear;
    }
}

