﻿namespace COSC2100Assignment5BrodyDentinger
{
    partial class TechSupportForm
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
            this.techSupportExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // techSupportExitButton
            // 
            this.techSupportExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.techSupportExitButton.Location = new System.Drawing.Point(22, 13);
            this.techSupportExitButton.Name = "techSupportExitButton";
            this.techSupportExitButton.Size = new System.Drawing.Size(75, 23);
            this.techSupportExitButton.TabIndex = 0;
            this.techSupportExitButton.Text = "Exit";
            this.techSupportExitButton.UseVisualStyleBackColor = false;
            this.techSupportExitButton.Click += new System.EventHandler(this.techSupportExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brody Dentinger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "100561604";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "brody.dentinger@dcmail.ca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(19, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "For Technical Support or to Report a Bug, Please Contact:";
            // 
            // TechSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.techSupportExitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TechSupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button techSupportExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}