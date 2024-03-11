    namespace WinFormsApp2
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
            squarearea = new Button();
            rectanglearea = new Button();
            trianglearea = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // squarearea
            // 
            squarearea.Location = new Point(12, 12);
            squarearea.Name = "squarearea";
            squarearea.Size = new Size(165, 27);
            squarearea.TabIndex = 0;
            squarearea.Text = " areaoa square";
            squarearea.UseVisualStyleBackColor = true;
            squarearea.Click += button1_Click;
            // 
            // rectanglearea
            // 
            rectanglearea.Location = new Point(12, 45);
            rectanglearea.Name = "rectanglearea";
            rectanglearea.Size = new Size(165, 27);
            rectanglearea.TabIndex = 1;
            rectanglearea.Text = "area of rectabgle";
            rectanglearea.UseVisualStyleBackColor = true;
            rectanglearea.Click += button2_Click;
            // 
            // trianglearea
            // 
            trianglearea.Location = new Point(12, 78);
            trianglearea.Name = "trianglearea";
            trianglearea.Size = new Size(165, 27);
            trianglearea.TabIndex = 2;
            trianglearea.Text = "Angle fo triagngle button";
            trianglearea.UseVisualStyleBackColor = true;
            trianglearea.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(144, 319);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 413);
            Controls.Add(checkBox1);
            Controls.Add(trianglearea);
            Controls.Add(rectanglearea);
            Controls.Add(squarearea);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button squarearea;
        private Button rectanglearea;
        private Button trianglearea;
        private CheckBox checkBox1;
    }
}
