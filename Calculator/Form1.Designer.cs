namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(14, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(112, 415);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(210, 415);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 107);
            this.button3.TabIndex = 2;
            this.button3.Text = ")";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(309, 415);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 107);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_press);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Desktop;
            this.button5.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(408, 301);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 221);
            this.button5.TabIndex = 4;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.result_press);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Desktop;
            this.button6.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(408, 186);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 107);
            this.button6.TabIndex = 9;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_press);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Desktop;
            this.button7.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(309, 300);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 107);
            this.button7.TabIndex = 8;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_press);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Desktop;
            this.button8.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(210, 300);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 107);
            this.button8.TabIndex = 7;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Desktop;
            this.button9.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(112, 300);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 107);
            this.button9.TabIndex = 6;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Desktop;
            this.button10.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(14, 300);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 107);
            this.button10.TabIndex = 5;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Desktop;
            this.button11.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(406, 71);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 107);
            this.button11.TabIndex = 14;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.function_press);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Desktop;
            this.button12.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button12.Location = new System.Drawing.Point(309, 185);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 107);
            this.button12.TabIndex = 13;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_press);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Desktop;
            this.button13.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button13.Location = new System.Drawing.Point(210, 185);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(91, 107);
            this.button13.TabIndex = 12;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Desktop;
            this.button14.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button14.Location = new System.Drawing.Point(112, 185);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(91, 107);
            this.button14.TabIndex = 11;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Desktop;
            this.button15.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button15.Location = new System.Drawing.Point(14, 185);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(91, 107);
            this.button15.TabIndex = 10;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.Desktop;
            this.button17.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button17.Location = new System.Drawing.Point(309, 71);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(91, 107);
            this.button17.TabIndex = 18;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operator_press);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.Desktop;
            this.button18.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button18.Location = new System.Drawing.Point(210, 71);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(91, 107);
            this.button18.TabIndex = 17;
            this.button18.Text = "9";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Desktop;
            this.button19.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button19.Location = new System.Drawing.Point(112, 71);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(91, 107);
            this.button19.TabIndex = 16;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.Desktop;
            this.button20.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button20.Location = new System.Drawing.Point(14, 71);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(91, 107);
            this.button20.TabIndex = 15;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expression_press);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.Desktop;
            this.textbox.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textbox.ForeColor = System.Drawing.SystemColors.Window;
            this.textbox.Location = new System.Drawing.Point(14, 16);
            this.textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(485, 42);
            this.textbox.TabIndex = 20;
            this.textbox.Text = "0";
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(513, 535);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Button button15;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox textbox;
    }
}