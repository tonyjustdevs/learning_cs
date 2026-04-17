namespace WinFormsApp1
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
            button2 = new Button();
            main_label = new Label();
            globalLabelCount = new Label();
            msg1label = new Label();
            msg2label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(219, 295);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Msg 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 295);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Msg 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // main_label
            // 
            main_label.AutoSize = true;
            main_label.Location = new Point(327, 203);
            main_label.Name = "main_label";
            main_label.Size = new Size(78, 32);
            main_label.TabIndex = 2;
            main_label.Text = "label1";
            main_label.Click += label1_Click;
            // 
            // globalLabelCount
            // 
            globalLabelCount.BorderStyle = BorderStyle.Fixed3D;
            globalLabelCount.Location = new Point(381, 372);
            globalLabelCount.Name = "globalLabelCount";
            globalLabelCount.Size = new Size(57, 69);
            globalLabelCount.TabIndex = 3;
            globalLabelCount.Text = "0";
            globalLabelCount.Click += label2_Click;
            // 
            // msg1label
            // 
            msg1label.BorderStyle = BorderStyle.Fixed3D;
            msg1label.Location = new Point(264, 372);
            msg1label.Name = "msg1label";
            msg1label.Size = new Size(57, 69);
            msg1label.TabIndex = 4;
            msg1label.Text = "0";
            msg1label.Click += msg1count_click;
            // 
            // msg2label
            // 
            msg2label.BorderStyle = BorderStyle.Fixed3D;
            msg2label.Location = new Point(494, 372);
            msg2label.Name = "msg2label";
            msg2label.Size = new Size(57, 69);
            msg2label.TabIndex = 5;
            msg2label.Text = "0";
            msg2label.Click += msg2count_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msg2label);
            Controls.Add(msg1label);
            Controls.Add(globalLabelCount);
            Controls.Add(main_label);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label main_label;
        private Label globalLabelCount;
        private Label msg1label;
        private Label msg2label;
    }
}
