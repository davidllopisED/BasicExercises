namespace Ejercicio9
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Even = new System.Windows.Forms.Button();
            this.Odd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(51, 64);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 24);
            this.ComboBox.TabIndex = 0;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // Even
            // 
            this.Even.Location = new System.Drawing.Point(263, 65);
            this.Even.Name = "Even";
            this.Even.Size = new System.Drawing.Size(75, 23);
            this.Even.TabIndex = 1;
            this.Even.Text = "Even";
            this.Even.UseVisualStyleBackColor = true;
            this.Even.Click += new System.EventHandler(this.Even_Click);
            // 
            // Odd
            // 
            this.Odd.Location = new System.Drawing.Point(368, 65);
            this.Odd.Name = "Odd";
            this.Odd.Size = new System.Drawing.Size(75, 23);
            this.Odd.TabIndex = 2;
            this.Odd.Text = "Odd";
            this.Odd.UseVisualStyleBackColor = true;
            this.Odd.Click += new System.EventHandler(this.Odd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Odd);
            this.Controls.Add(this.Even);
            this.Controls.Add(this.ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button Even;
        private System.Windows.Forms.Button Odd;
        private System.Windows.Forms.TextBox textBox1;
    }
}

