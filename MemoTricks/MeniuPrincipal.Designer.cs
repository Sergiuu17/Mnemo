﻿namespace MemoTricks
{
    partial class MeniuPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.learnPeg = new System.Windows.Forms.Button();
            this.testPeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sistemul Peg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sistemul \"loci\"";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sistemul major";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // learnPeg
            // 
            this.learnPeg.Location = new System.Drawing.Point(363, 53);
            this.learnPeg.Name = "learnPeg";
            this.learnPeg.Size = new System.Drawing.Size(75, 23);
            this.learnPeg.TabIndex = 3;
            this.learnPeg.Text = "Invata";
            this.learnPeg.UseVisualStyleBackColor = true;
            this.learnPeg.Visible = false;
            this.learnPeg.Click += new System.EventHandler(this.learnPeg_Click);
            // 
            // testPeg
            // 
            this.testPeg.Location = new System.Drawing.Point(362, 107);
            this.testPeg.Name = "testPeg";
            this.testPeg.Size = new System.Drawing.Size(75, 23);
            this.testPeg.TabIndex = 4;
            this.testPeg.Text = "Testeaza";
            this.testPeg.UseVisualStyleBackColor = true;
            this.testPeg.Visible = false;
            this.testPeg.Click += new System.EventHandler(this.testPeg_Click);
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(686, 419);
            this.Controls.Add(this.testPeg);
            this.Controls.Add(this.learnPeg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MeniuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button learnPeg;
        private System.Windows.Forms.Button testPeg;

    }
}

