﻿namespace HalloAsync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 12);
            button1.Name = "button1";
            button1.Size = new Size(360, 46);
            button1.TabIndex = 0;
            button1.Text = "Ohne Thread";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(40, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(704, 46);
            progressBar1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(40, 144);
            button2.Name = "button2";
            button2.Size = new Size(360, 46);
            button2.TabIndex = 2;
            button2.Text = "Start Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(56, 211);
            button3.Name = "button3";
            button3.Size = new Size(360, 46);
            button3.TabIndex = 2;
            button3.Text = "Start TasksScheduler";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(158, 276);
            button4.Name = "button4";
            button4.Size = new Size(360, 46);
            button4.TabIndex = 3;
            button4.Text = "Start Async";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_ClickAsync;
            // 
            // button5
            // 
            button5.Location = new Point(234, 353);
            button5.Name = "button5";
            button5.Size = new Size(360, 46);
            button5.TabIndex = 3;
            button5.Text = "Async Lahm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(472, 158);
            button6.Name = "button6";
            button6.Size = new Size(360, 46);
            button6.TabIndex = 2;
            button6.Text = "Start TPL";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}