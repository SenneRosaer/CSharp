namespace Sorting
{
    partial class Main
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
            this.bubble_list = new System.Windows.Forms.ListBox();
            this.bubble_add = new System.Windows.Forms.Button();
            this.bubble_input = new System.Windows.Forms.RichTextBox();
            this.bubble_sort = new System.Windows.Forms.Button();
            this.merge_list = new System.Windows.Forms.ListBox();
            this.merge_input = new System.Windows.Forms.RichTextBox();
            this.merge_add = new System.Windows.Forms.Button();
            this.bubble_clear = new System.Windows.Forms.Button();
            this.merge_clear = new System.Windows.Forms.Button();
            this.merge_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bubble_list
            // 
            this.bubble_list.FormattingEnabled = true;
            this.bubble_list.Location = new System.Drawing.Point(72, 28);
            this.bubble_list.Name = "bubble_list";
            this.bubble_list.Size = new System.Drawing.Size(240, 95);
            this.bubble_list.TabIndex = 1;
            // 
            // bubble_add
            // 
            this.bubble_add.Location = new System.Drawing.Point(237, 139);
            this.bubble_add.Name = "bubble_add";
            this.bubble_add.Size = new System.Drawing.Size(75, 23);
            this.bubble_add.TabIndex = 2;
            this.bubble_add.Text = "Add";
            this.bubble_add.UseVisualStyleBackColor = true;
            this.bubble_add.Click += new System.EventHandler(this.bubble_add_Click);
            // 
            // bubble_input
            // 
            this.bubble_input.Location = new System.Drawing.Point(72, 139);
            this.bubble_input.Name = "bubble_input";
            this.bubble_input.Size = new System.Drawing.Size(159, 23);
            this.bubble_input.TabIndex = 3;
            this.bubble_input.Text = "";
            // 
            // bubble_sort
            // 
            this.bubble_sort.Location = new System.Drawing.Point(72, 197);
            this.bubble_sort.Name = "bubble_sort";
            this.bubble_sort.Size = new System.Drawing.Size(240, 45);
            this.bubble_sort.TabIndex = 4;
            this.bubble_sort.Text = "Bubble Sort";
            this.bubble_sort.UseVisualStyleBackColor = true;
            this.bubble_sort.Click += new System.EventHandler(this.bubble_sort_Click);
            // 
            // merge_list
            // 
            this.merge_list.FormattingEnabled = true;
            this.merge_list.Location = new System.Drawing.Point(482, 28);
            this.merge_list.Name = "merge_list";
            this.merge_list.Size = new System.Drawing.Size(240, 95);
            this.merge_list.TabIndex = 5;
            // 
            // merge_input
            // 
            this.merge_input.Location = new System.Drawing.Point(482, 139);
            this.merge_input.Name = "merge_input";
            this.merge_input.Size = new System.Drawing.Size(159, 23);
            this.merge_input.TabIndex = 6;
            this.merge_input.Text = "";
            // 
            // merge_add
            // 
            this.merge_add.Location = new System.Drawing.Point(647, 139);
            this.merge_add.Name = "merge_add";
            this.merge_add.Size = new System.Drawing.Size(75, 23);
            this.merge_add.TabIndex = 7;
            this.merge_add.Text = "Add";
            this.merge_add.UseVisualStyleBackColor = true;
            this.merge_add.Click += new System.EventHandler(this.merge_add_Click);
            // 
            // bubble_clear
            // 
            this.bubble_clear.Location = new System.Drawing.Point(237, 168);
            this.bubble_clear.Name = "bubble_clear";
            this.bubble_clear.Size = new System.Drawing.Size(75, 23);
            this.bubble_clear.TabIndex = 8;
            this.bubble_clear.Text = "Clear";
            this.bubble_clear.UseVisualStyleBackColor = true;
            this.bubble_clear.Click += new System.EventHandler(this.bubble_clear_Click);
            // 
            // merge_clear
            // 
            this.merge_clear.Location = new System.Drawing.Point(647, 168);
            this.merge_clear.Name = "merge_clear";
            this.merge_clear.Size = new System.Drawing.Size(75, 23);
            this.merge_clear.TabIndex = 9;
            this.merge_clear.Text = "Clear";
            this.merge_clear.UseVisualStyleBackColor = true;
            this.merge_clear.Click += new System.EventHandler(this.merge_clear_Click);
            // 
            // merge_sort
            // 
            this.merge_sort.Location = new System.Drawing.Point(482, 197);
            this.merge_sort.Name = "merge_sort";
            this.merge_sort.Size = new System.Drawing.Size(240, 45);
            this.merge_sort.TabIndex = 10;
            this.merge_sort.Text = "Merge Sort";
            this.merge_sort.UseVisualStyleBackColor = true;
            this.merge_sort.Click += new System.EventHandler(this.merge_sort_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.merge_sort);
            this.Controls.Add(this.merge_clear);
            this.Controls.Add(this.bubble_clear);
            this.Controls.Add(this.merge_add);
            this.Controls.Add(this.merge_input);
            this.Controls.Add(this.merge_list);
            this.Controls.Add(this.bubble_sort);
            this.Controls.Add(this.bubble_input);
            this.Controls.Add(this.bubble_add);
            this.Controls.Add(this.bubble_list);
            this.Name = "Main";
            this.Text = "Sorting";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox bubble_list;
        private System.Windows.Forms.Button bubble_add;
        private System.Windows.Forms.RichTextBox bubble_input;
        private System.Windows.Forms.Button bubble_sort;
        private System.Windows.Forms.ListBox merge_list;
        private System.Windows.Forms.RichTextBox merge_input;
        private System.Windows.Forms.Button merge_add;
        private System.Windows.Forms.Button bubble_clear;
        private System.Windows.Forms.Button merge_clear;
        private System.Windows.Forms.Button merge_sort;
    }
}

