namespace New_calc
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.additionOp = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.subtractionOp = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.multiplicationOp = new System.Windows.Forms.Button();
            this.divisionOp = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.Label();
            this.lb_history = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historyClear = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(521, 64);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 94);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 86);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(113, 94);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 86);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(214, 94);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 86);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 86);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(113, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 86);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(214, 186);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 86);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 278);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 86);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(113, 278);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 86);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(214, 278);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 86);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 370);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(95, 86);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // additionOp
            // 
            this.additionOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionOp.Location = new System.Drawing.Point(334, 278);
            this.additionOp.Name = "additionOp";
            this.additionOp.Size = new System.Drawing.Size(95, 86);
            this.additionOp.TabIndex = 13;
            this.additionOp.Text = "+";
            this.additionOp.UseVisualStyleBackColor = true;
            this.additionOp.Click += new System.EventHandler(this.btn_operator_click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(334, 94);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(95, 86);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_all_btn_click);
            // 
            // subtractionOp
            // 
            this.subtractionOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionOp.Location = new System.Drawing.Point(334, 186);
            this.subtractionOp.Name = "subtractionOp";
            this.subtractionOp.Size = new System.Drawing.Size(95, 86);
            this.subtractionOp.TabIndex = 14;
            this.subtractionOp.Text = "-";
            this.subtractionOp.UseVisualStyleBackColor = true;
            this.subtractionOp.Click += new System.EventHandler(this.btn_operator_click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsBtn.Location = new System.Drawing.Point(214, 370);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(95, 86);
            this.equalsBtn.TabIndex = 15;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.btn_equals_click);
            // 
            // multiplicationOp
            // 
            this.multiplicationOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationOp.Location = new System.Drawing.Point(438, 94);
            this.multiplicationOp.Name = "multiplicationOp";
            this.multiplicationOp.Size = new System.Drawing.Size(95, 86);
            this.multiplicationOp.TabIndex = 18;
            this.multiplicationOp.Text = "*";
            this.multiplicationOp.UseVisualStyleBackColor = true;
            this.multiplicationOp.Click += new System.EventHandler(this.btn_operator_click);
            // 
            // divisionOp
            // 
            this.divisionOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionOp.Location = new System.Drawing.Point(438, 186);
            this.divisionOp.Name = "divisionOp";
            this.divisionOp.Size = new System.Drawing.Size(95, 86);
            this.divisionOp.TabIndex = 17;
            this.divisionOp.Text = "/";
            this.divisionOp.UseVisualStyleBackColor = true;
            this.divisionOp.Click += new System.EventHandler(this.btn_operator_click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(113, 370);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(95, 86);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btn_digit_click);
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Location = new System.Drawing.Point(552, 37);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(0, 16);
            this.lbHistory.TabIndex = 20;
            // 
            // lb_history
            // 
            this.lb_history.AutoSize = true;
            this.lb_history.Location = new System.Drawing.Point(552, 46);
            this.lb_history.Name = "lb_history";
            this.lb_history.Size = new System.Drawing.Size(0, 16);
            this.lb_history.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "History";
            // 
            // historyClear
            // 
            this.historyClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyClear.Location = new System.Drawing.Point(334, 370);
            this.historyClear.Name = "historyClear";
            this.historyClear.Size = new System.Drawing.Size(199, 86);
            this.historyClear.TabIndex = 23;
            this.historyClear.Text = "Clear history";
            this.historyClear.UseVisualStyleBackColor = true;
            this.historyClear.Click += new System.EventHandler(this.clear_history_btn);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(12, 478);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(495, 16);
            this.welcome.TabIndex = 24;
            this.welcome.Text = "Welcome to my calculator application, I hope you enjoy using this simple program!" +
    " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 503);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.historyClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_history);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.multiplicationOp);
            this.Controls.Add(this.divisionOp);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.subtractionOp);
            this.Controls.Add(this.additionOp);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtOutput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button additionOp;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button subtractionOp;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button multiplicationOp;
        private System.Windows.Forms.Button divisionOp;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lb_history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button historyClear;
        private System.Windows.Forms.Label welcome;
    }
}

