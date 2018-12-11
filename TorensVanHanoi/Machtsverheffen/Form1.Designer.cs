namespace Machtsverheffen
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
            this.schijvenLabel = new System.Windows.Forms.Label();
            this.schijvenTextBox = new System.Windows.Forms.TextBox();
            this.berekenButton = new System.Windows.Forms.Button();
            this.antwoordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // schijvenLabel
            // 
            this.schijvenLabel.AutoSize = true;
            this.schijvenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schijvenLabel.Location = new System.Drawing.Point(32, 12);
            this.schijvenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schijvenLabel.Name = "schijvenLabel";
            this.schijvenLabel.Size = new System.Drawing.Size(159, 26);
            this.schijvenLabel.TabIndex = 0;
            this.schijvenLabel.Text = "Aantal schijven";
            // 
            // schijvenTextBox
            // 
            this.schijvenTextBox.Location = new System.Drawing.Point(29, 78);
            this.schijvenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schijvenTextBox.Name = "schijvenTextBox";
            this.schijvenTextBox.Size = new System.Drawing.Size(160, 20);
            this.schijvenTextBox.TabIndex = 1;
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(79, 141);
            this.berekenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(56, 19);
            this.berekenButton.TabIndex = 2;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            // 
            // antwoordLabel
            // 
            this.antwoordLabel.AutoSize = true;
            this.antwoordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordLabel.Location = new System.Drawing.Point(11, 211);
            this.antwoordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.antwoordLabel.Name = "antwoordLabel";
            this.antwoordLabel.Size = new System.Drawing.Size(101, 26);
            this.antwoordLabel.TabIndex = 3;
            this.antwoordLabel.Text = "antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.antwoordLabel);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.schijvenTextBox);
            this.Controls.Add(this.schijvenLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schijvenLabel;
        private System.Windows.Forms.TextBox schijvenTextBox;
        private System.Windows.Forms.Button berekenButton;
        private System.Windows.Forms.Label antwoordLabel;
    }
}

