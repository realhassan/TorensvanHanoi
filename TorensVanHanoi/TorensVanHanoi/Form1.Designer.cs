namespace TorensVanHanoi
{
    partial class MenuForm
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
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnMachtsverheffen = new System.Windows.Forms.Button();
            this.btnRecursie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(126, 151);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(125, 105);
            this.btnForLoop.TabIndex = 0;
            this.btnForLoop.Text = "For-loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            // 
            // btnMachtsverheffen
            // 
            this.btnMachtsverheffen.Location = new System.Drawing.Point(257, 151);
            this.btnMachtsverheffen.Name = "btnMachtsverheffen";
            this.btnMachtsverheffen.Size = new System.Drawing.Size(125, 105);
            this.btnMachtsverheffen.TabIndex = 1;
            this.btnMachtsverheffen.Text = "Machtsverheffen";
            this.btnMachtsverheffen.UseVisualStyleBackColor = true;
            // 
            // btnRecursie
            // 
            this.btnRecursie.Location = new System.Drawing.Point(388, 151);
            this.btnRecursie.Name = "btnRecursie";
            this.btnRecursie.Size = new System.Drawing.Size(125, 105);
            this.btnRecursie.TabIndex = 2;
            this.btnRecursie.Text = "Recursie";
            this.btnRecursie.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecursie);
            this.Controls.Add(this.btnMachtsverheffen);
            this.Controls.Add(this.btnForLoop);
            this.Name = "MenuForm";
            this.Text = "Torens van Hanoi Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnMachtsverheffen;
        private System.Windows.Forms.Button btnRecursie;
    }
}

