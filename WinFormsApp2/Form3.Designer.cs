﻿namespace WinFormsApp2
{
    partial class rectangleareaform
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 33);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // button1
            // 
            button1.Location = new Point(17, 211);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(272, 39);
            button1.TabIndex = 3;
            button1.Text = "Calculate Area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 94);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 70);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 142);
            label1.Name = "label1";
            label1.Size = new Size(120, 41);
            label1.TabIndex = 9;
            label1.Text = "lblArea";
            // 
            // rectangleareaform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 265);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "rectangleareaform";
            Text = "Rectangle Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}