namespace Ejercicio7
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
            this.ChoosenColour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "Pink",
            "Green"});
            this.ComboBox.Location = new System.Drawing.Point(278, 106);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 24);
            this.ComboBox.TabIndex = 0;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // ChoosenColour
            // 
            this.ChoosenColour.Location = new System.Drawing.Point(163, 259);
            this.ChoosenColour.Name = "ChoosenColour";
            this.ChoosenColour.Size = new System.Drawing.Size(365, 22);
            this.ChoosenColour.TabIndex = 1;
            this.ChoosenColour.TextChanged += new System.EventHandler(this.ChoosenColor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoosenColour);
            this.Controls.Add(this.ComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TextBox ChoosenColour;
    }
}

