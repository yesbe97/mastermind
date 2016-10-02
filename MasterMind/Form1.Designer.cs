namespace MasterMind
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
            this.guessBox1 = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.guessBox2 = new System.Windows.Forms.TextBox();
            this.guessBox3 = new System.Windows.Forms.TextBox();
            this.guessBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guessBox1
            // 
            this.guessBox1.Location = new System.Drawing.Point(13, 12);
            this.guessBox1.Name = "guessBox1";
            this.guessBox1.Size = new System.Drawing.Size(20, 20);
            this.guessBox1.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(26, 38);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Controleren";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // guessBox2
            // 
            this.guessBox2.Location = new System.Drawing.Point(39, 12);
            this.guessBox2.Name = "guessBox2";
            this.guessBox2.Size = new System.Drawing.Size(20, 20);
            this.guessBox2.TabIndex = 2;
            // 
            // guessBox3
            // 
            this.guessBox3.Location = new System.Drawing.Point(66, 12);
            this.guessBox3.Name = "guessBox3";
            this.guessBox3.Size = new System.Drawing.Size(20, 20);
            this.guessBox3.TabIndex = 3;
            // 
            // guessBox4
            // 
            this.guessBox4.Location = new System.Drawing.Point(92, 12);
            this.guessBox4.Name = "guessBox4";
            this.guessBox4.Size = new System.Drawing.Size(20, 20);
            this.guessBox4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.guessBox4);
            this.Controls.Add(this.guessBox3);
            this.Controls.Add(this.guessBox2);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.guessBox1);
            this.Name = "Form1";
            this.Text = "MasterMind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessBox1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox guessBox2;
        private System.Windows.Forms.TextBox guessBox3;
        private System.Windows.Forms.TextBox guessBox4;
    }
}

