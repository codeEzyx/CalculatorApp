﻿namespace CalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            number0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            textBox_Result = new TextBox();
            labelOperation = new Label();
            SuspendLayout();
            // 
            // number0
            // 
            number0.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number0.Location = new Point(45, 131);
            number0.Name = "number0";
            number0.Size = new Size(60, 60);
            number0.TabIndex = 0;
            number0.Text = "7";
            number0.UseVisualStyleBackColor = true;
            number0.Click += button_click;
            // 
            // button1
            // 
            button1.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(111, 131);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.Text = "8";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(177, 131);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.Text = "9";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button3.Location = new Point(243, 131);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += operator_click;
            // 
            // button4
            // 
            button4.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(309, 131);
            button4.Name = "button4";
            button4.Size = new Size(73, 60);
            button4.TabIndex = 4;
            button4.Text = "CE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(309, 197);
            button5.Name = "button5";
            button5.Size = new Size(73, 60);
            button5.TabIndex = 9;
            button5.Text = "C";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button6.Location = new Point(243, 197);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 8;
            button6.Text = "*";
            button6.UseVisualStyleBackColor = true;
            button6.Click += operator_click;
            // 
            // button7
            // 
            button7.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(177, 197);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // button8
            // 
            button8.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(111, 197);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 6;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(45, 197);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 5;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // button10
            // 
            button10.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button10.Location = new Point(309, 263);
            button10.Name = "button10";
            button10.Size = new Size(73, 126);
            button10.TabIndex = 14;
            button10.Text = "=";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button11.Location = new Point(243, 263);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 13;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += operator_click;
            // 
            // button12
            // 
            button12.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(177, 263);
            button12.Name = "button12";
            button12.Size = new Size(60, 60);
            button12.TabIndex = 12;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_click;
            // 
            // button13
            // 
            button13.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(111, 263);
            button13.Name = "button13";
            button13.Size = new Size(60, 60);
            button13.TabIndex = 11;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_click;
            // 
            // button14
            // 
            button14.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(45, 263);
            button14.Name = "button14";
            button14.Size = new Size(60, 60);
            button14.TabIndex = 10;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // button16
            // 
            button16.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button16.Location = new Point(243, 329);
            button16.Name = "button16";
            button16.Size = new Size(60, 60);
            button16.TabIndex = 18;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += operator_click;
            // 
            // button17
            // 
            button17.Font = new Font("Sans Serif Collection", 15F, FontStyle.Bold);
            button17.Location = new Point(177, 329);
            button17.Name = "button17";
            button17.Size = new Size(60, 60);
            button17.TabIndex = 17;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_click;
            // 
            // button18
            // 
            button18.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(45, 329);
            button18.Name = "button18";
            button18.Size = new Size(126, 60);
            button18.TabIndex = 16;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_click;
            // 
            // button19
            // 
            button19.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(45, 329);
            button19.Name = "button19";
            button19.Size = new Size(0, 0);
            button19.TabIndex = 15;
            button19.Text = "1";
            button19.UseVisualStyleBackColor = true;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(45, 71);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(337, 54);
            textBox_Result.TabIndex = 19;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.BackColor = SystemColors.Control;
            labelOperation.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            labelOperation.ForeColor = SystemColors.ActiveBorder;
            labelOperation.Location = new Point(45, 29);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(0, 39);
            labelOperation.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 426);
            Controls.Add(labelOperation);
            Controls.Add(textBox_Result);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(number0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button number0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private TextBox textBox_Result;
        private Label labelOperation;
    }
}
