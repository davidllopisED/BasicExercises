namespace Ejercicio5
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
            this.Lion = new System.Windows.Forms.CheckBox();
            this.Tiger = new System.Windows.Forms.CheckBox();
            this.Eagle = new System.Windows.Forms.CheckBox();
            this.ChoosenAnimals = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lion
            // 
            this.Lion.AutoSize = true;
            this.Lion.Location = new System.Drawing.Point(125, 91);
            this.Lion.Name = "Lion";
            this.Lion.Size = new System.Drawing.Size(57, 21);
            this.Lion.TabIndex = 0;
            this.Lion.Text = "Lion";
            this.Lion.UseVisualStyleBackColor = true;
            // 
            // Tiger
            // 
            this.Tiger.AutoSize = true;
            this.Tiger.Location = new System.Drawing.Point(125, 137);
            this.Tiger.Name = "Tiger";
            this.Tiger.Size = new System.Drawing.Size(63, 21);
            this.Tiger.TabIndex = 1;
            this.Tiger.Text = "Tiger";
            this.Tiger.UseVisualStyleBackColor = true;
            // 
            // Eagle
            // 
            this.Eagle.AutoSize = true;
            this.Eagle.Location = new System.Drawing.Point(125, 185);
            this.Eagle.Name = "Eagle";
            this.Eagle.Size = new System.Drawing.Size(66, 21);
            this.Eagle.TabIndex = 2;
            this.Eagle.Text = "Eagle";
            this.Eagle.UseVisualStyleBackColor = true;
            // 
            // ChoosenAnimals
            // 
            this.ChoosenAnimals.Location = new System.Drawing.Point(125, 264);
            this.ChoosenAnimals.Name = "ChoosenAnimals";
            this.ChoosenAnimals.Size = new System.Drawing.Size(321, 22);
            this.ChoosenAnimals.TabIndex = 3;
            this.ChoosenAnimals.Text = "Choosen Animals:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(125, 222);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ChoosenAnimals);
            this.Controls.Add(this.Eagle);
            this.Controls.Add(this.Tiger);
            this.Controls.Add(this.Lion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Lion;
        private System.Windows.Forms.CheckBox Tiger;
        private System.Windows.Forms.CheckBox Eagle;
        private System.Windows.Forms.TextBox ChoosenAnimals;
        private System.Windows.Forms.Button OkButton;
    }
}

