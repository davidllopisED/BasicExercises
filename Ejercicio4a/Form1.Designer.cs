namespace Ejercicio4a
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
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(156, 93);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(100, 22);
            this.Operand1.TabIndex = 0;
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(156, 158);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(100, 22);
            this.Operand2.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(223, 203);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(337, 55);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(79, 23);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.UseWaitCursor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(337, 102);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(79, 23);
            this.Substract.TabIndex = 4;
            this.Substract.Text = "Substract";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Operation
            // 
            this.Operation.Location = new System.Drawing.Point(337, 177);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(79, 22);
            this.Operation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operación Seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione la operación a realizar";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(577, 137);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 8;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(577, 188);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 23);
            this.Reset.TabIndex = 9;
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
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Reset;
    }
}

