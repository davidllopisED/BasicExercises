namespace Ejercicio8
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
            this.Classrom2 = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Classrom1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Classrom2
            // 
            this.Classrom2.Location = new System.Drawing.Point(80, 255);
            this.Classrom2.Name = "Classrom2";
            this.Classrom2.Size = new System.Drawing.Size(77, 61);
            this.Classrom2.TabIndex = 1;
            this.Classrom2.Text = "Classrom2\r\n";
            this.Classrom2.UseVisualStyleBackColor = true;
            this.Classrom2.Click += new System.EventHandler(this.Classrom2_Click);
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(80, 320);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(77, 61);
            this.ClearList.TabIndex = 2;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(80, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(77, 68);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Classrom1
            // 
            this.Classrom1.Location = new System.Drawing.Point(80, 188);
            this.Classrom1.Name = "Classrom1";
            this.Classrom1.Size = new System.Drawing.Size(77, 61);
            this.Classrom1.TabIndex = 0;
            this.Classrom1.Text = "Classrom1";
            this.Classrom1.UseVisualStyleBackColor = true;
            this.Classrom1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.Classrom2);
            this.Controls.Add(this.Classrom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Classrom2;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Classrom1;
    }
}

