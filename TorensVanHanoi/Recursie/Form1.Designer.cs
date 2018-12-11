namespace Recursie
{
    partial class Recursie
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
            this.berekenButton = new System.Windows.Forms.Button();
            this.schijvenTextBox = new System.Windows.Forms.TextBox();
            this.schijvenLabel = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(88, 133);
            this.berekenButton.Margin = new System.Windows.Forms.Padding(2);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(56, 19);
            this.berekenButton.TabIndex = 9;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // schijvenTextBox
            // 
            this.schijvenTextBox.Location = new System.Drawing.Point(38, 87);
            this.schijvenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.schijvenTextBox.Name = "schijvenTextBox";
            this.schijvenTextBox.Size = new System.Drawing.Size(160, 20);
            this.schijvenTextBox.TabIndex = 8;
            // 
            // schijvenLabel
            // 
            this.schijvenLabel.AutoSize = true;
            this.schijvenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schijvenLabel.Location = new System.Drawing.Point(39, 22);
            this.schijvenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schijvenLabel.Name = "schijvenLabel";
            this.schijvenLabel.Size = new System.Drawing.Size(159, 26);
            this.schijvenLabel.TabIndex = 7;
            this.schijvenLabel.Text = "Aantal schijven";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(61, 179);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(115, 29);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Antwoord";
            // 
            // Recursie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.schijvenTextBox);
            this.Controls.Add(this.schijvenLabel);
            this.Controls.Add(this.lblAnswer);
            this.Name = "Recursie";
            this.Text = "Recursie Torens van Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berekenButton;
        private System.Windows.Forms.TextBox schijvenTextBox;
        private System.Windows.Forms.Label schijvenLabel;
        private System.Windows.Forms.Label lblAnswer;
    }
}

