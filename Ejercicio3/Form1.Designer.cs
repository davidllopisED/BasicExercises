namespace Ejercicio3
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
            this.buttonSum = new System.Windows.Forms.Button();
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(74, 89);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(56, 27);
            this.buttonSum.TabIndex = 0;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(227, 62);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(91, 22);
            this.Operand1.TabIndex = 1;
            this.Operand1.TextChanged += new System.EventHandler(this.Operand1_TextChanged);
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(226, 112);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(91, 22);
            this.Operand2.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(222, 170);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(95, 22);
            this.Result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operand1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operand2";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(419, 94);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(63, 40);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.buttonSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Reset;
    }
}

