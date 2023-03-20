namespace WindowsFormsApplication1
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
            this.wishlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FillBtn = new System.Windows.Forms.Button();
            this.Sortbuttonbox = new System.Windows.Forms.Button();
            this.Clearbuttonbox = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.SelectionOutputBox = new System.Windows.Forms.TextBox();
            this.CountOutputBox = new System.Windows.Forms.TextBox();
            this.Closebuttonbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wish List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wishlist
            // 
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(83, 88);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(230, 186);
            this.wishlist.TabIndex = 1;
            this.wishlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(471, 91);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(91, 21);
            this.FillBtn.TabIndex = 5;
            this.FillBtn.Text = "Fill";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.Filbuttonbox_Click);
            // 
            // Sortbuttonbox
            // 
            this.Sortbuttonbox.Location = new System.Drawing.Point(471, 135);
            this.Sortbuttonbox.Name = "Sortbuttonbox";
            this.Sortbuttonbox.Size = new System.Drawing.Size(91, 20);
            this.Sortbuttonbox.TabIndex = 6;
            this.Sortbuttonbox.Text = "Sort";
            this.Sortbuttonbox.UseVisualStyleBackColor = true;
            this.Sortbuttonbox.Click += new System.EventHandler(this.Setbuttonbox_Click);
            // 
            // Clearbuttonbox
            // 
            this.Clearbuttonbox.Location = new System.Drawing.Point(471, 179);
            this.Clearbuttonbox.Name = "Clearbuttonbox";
            this.Clearbuttonbox.Size = new System.Drawing.Size(91, 19);
            this.Clearbuttonbox.TabIndex = 7;
            this.Clearbuttonbox.Text = "Clear";
            this.Clearbuttonbox.UseVisualStyleBackColor = true;
            this.Clearbuttonbox.Click += new System.EventHandler(this.Clearbuttonbox_Click);
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(471, 222);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(90, 22);
            this.CountBtn.TabIndex = 8;
            this.CountBtn.Text = "Count";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.Countbuttonbox_Click);
            // 
            // SelectionOutputBox
            // 
            this.SelectionOutputBox.Location = new System.Drawing.Point(160, 297);
            this.SelectionOutputBox.Name = "SelectionOutputBox";
            this.SelectionOutputBox.Size = new System.Drawing.Size(121, 20);
            this.SelectionOutputBox.TabIndex = 9;
            this.SelectionOutputBox.TextChanged += new System.EventHandler(this.selectionbox_TextChanged);
            // 
            // CountOutputBox
            // 
            this.CountOutputBox.Location = new System.Drawing.Point(160, 357);
            this.CountOutputBox.Name = "CountOutputBox";
            this.CountOutputBox.Size = new System.Drawing.Size(121, 20);
            this.CountOutputBox.TabIndex = 9;
            this.CountOutputBox.TextChanged += new System.EventHandler(this.countOutput_TextChanged);
            // 
            // Closebuttonbox
            // 
            this.Closebuttonbox.Location = new System.Drawing.Point(472, 268);
            this.Closebuttonbox.Name = "Closebuttonbox";
            this.Closebuttonbox.Size = new System.Drawing.Size(90, 22);
            this.Closebuttonbox.TabIndex = 8;
            this.Closebuttonbox.Text = "Close";
            this.Closebuttonbox.UseVisualStyleBackColor = true;
            this.Closebuttonbox.Click += new System.EventHandler(this.Closebuttonbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 502);
            this.Controls.Add(this.CountOutputBox);
            this.Controls.Add(this.SelectionOutputBox);
            this.Controls.Add(this.Closebuttonbox);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.Clearbuttonbox);
            this.Controls.Add(this.Sortbuttonbox);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wishlist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button Sortbuttonbox;
        private System.Windows.Forms.Button Clearbuttonbox;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.TextBox SelectionOutputBox;
        private System.Windows.Forms.TextBox CountOutputBox;
        private System.Windows.Forms.Button Closebuttonbox;

    }
}

