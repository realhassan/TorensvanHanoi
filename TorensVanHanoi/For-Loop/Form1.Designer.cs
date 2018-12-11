namespace For_Loop
{
    partial class ForLoop
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.schijvenTextBox = new System.Windows.Forms.TextBox();
            this.schijvenLabel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(70, 198);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(115, 29);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Antwoord";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(97, 152);
            this.berekenButton.Margin = new System.Windows.Forms.Padding(2);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(56, 19);
            this.berekenButton.TabIndex = 5;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // schijvenTextBox
            // 
            this.schijvenTextBox.Location = new System.Drawing.Point(47, 106);
            this.schijvenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.schijvenTextBox.Name = "schijvenTextBox";
            this.schijvenTextBox.Size = new System.Drawing.Size(160, 20);
            this.schijvenTextBox.TabIndex = 4;
            // 
            // schijvenLabel
            // 
            this.schijvenLabel.AutoSize = true;
            this.schijvenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schijvenLabel.Location = new System.Drawing.Point(48, 41);
            this.schijvenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schijvenLabel.Name = "schijvenLabel";
            this.schijvenLabel.Size = new System.Drawing.Size(159, 26);
            this.schijvenLabel.TabIndex = 3;
            this.schijvenLabel.Text = "Aantal schijven";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(74, 255);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 29);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 293);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.schijvenTextBox);
            this.Controls.Add(this.schijvenLabel);
            this.Controls.Add(this.lblAnswer);
            this.Name = "ForLoop";
            this.Text = "For-Loop Torens van Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button berekenButton;
        private System.Windows.Forms.TextBox schijvenTextBox;
        private System.Windows.Forms.Label schijvenLabel;
        private System.Windows.Forms.Label lblTime;
    }
}

