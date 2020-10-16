namespace Ejercicio6
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
            this.Red = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.White = new System.Windows.Forms.RadioButton();
            this.Ok = new System.Windows.Forms.Button();
            this.ChoosenColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.SystemColors.Control;
            this.Red.Location = new System.Drawing.Point(263, 94);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 21);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(263, 134);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(57, 21);
            this.Blue.TabIndex = 1;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // White
            // 
            this.White.AutoSize = true;
            this.White.Location = new System.Drawing.Point(263, 174);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(65, 21);
            this.White.TabIndex = 2;
            this.White.TabStop = true;
            this.White.Text = "White";
            this.White.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(143, 198);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ChoosenColor
            // 
            this.ChoosenColor.Location = new System.Drawing.Point(178, 238);
            this.ChoosenColor.Name = "ChoosenColor";
            this.ChoosenColor.Size = new System.Drawing.Size(234, 22);
            this.ChoosenColor.TabIndex = 4;
            this.ChoosenColor.Text = "ChoosenColor:";
            this.ChoosenColor.TextChanged += new System.EventHandler(this.ChoosenColor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoosenColor);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton White;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox ChoosenColor;
    }
}

