namespace calculator2024
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_old = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Result);
            this.panel1.Controls.Add(this.lbl_old);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 158);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Result.Location = new System.Drawing.Point(0, 5);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(446, 105);
            this.lbl_Result.TabIndex = 1;
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Result.Click += new System.EventHandler(this.lbl_Result_Click);
            // 
            // lbl_old
            // 
            this.lbl_old.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_old.Location = new System.Drawing.Point(-1, 110);
            this.lbl_old.Name = "lbl_old";
            this.lbl_old.Size = new System.Drawing.Size(447, 48);
            this.lbl_old.TabIndex = 0;
            this.lbl_old.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_old.Click += new System.EventHandler(this.lbl_old_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnBackspace);
            this.flowLayoutPanel1.Controls.Add(this.btnHistory);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.btnMod);
            this.flowLayoutPanel1.Controls.Add(this.btnPower);
            this.flowLayoutPanel1.Controls.Add(this.btnSquare);
            this.flowLayoutPanel1.Controls.Add(this.btnSqrt);
            this.flowLayoutPanel1.Controls.Add(this.btnReciprocal);
            this.flowLayoutPanel1.Controls.Add(this.btn7);
            this.flowLayoutPanel1.Controls.Add(this.btn8);
            this.flowLayoutPanel1.Controls.Add(this.btn9);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button20);
            this.flowLayoutPanel1.Controls.Add(this.btn4);
            this.flowLayoutPanel1.Controls.Add(this.btn5);
            this.flowLayoutPanel1.Controls.Add(this.btn6);
            this.flowLayoutPanel1.Controls.Add(this.btnPlus);
            this.flowLayoutPanel1.Controls.Add(this.btnMinus);
            this.flowLayoutPanel1.Controls.Add(this.btn1);
            this.flowLayoutPanel1.Controls.Add(this.btn2);
            this.flowLayoutPanel1.Controls.Add(this.btn3);
            this.flowLayoutPanel1.Controls.Add(this.btnDivide);
            this.flowLayoutPanel1.Controls.Add(this.btnMultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnNegate);
            this.flowLayoutPanel1.Controls.Add(this.btn0);
            this.flowLayoutPanel1.Controls.Add(this.btnDecimal);
            this.flowLayoutPanel1.Controls.Add(this.btnAns);
            this.flowLayoutPanel1.Controls.Add(this.btnEquals);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 398);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 59);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(183, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(84, 59);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(273, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(84, 59);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "H";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(363, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(3, 68);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(84, 59);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(93, 68);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(84, 59);
            this.btnPower.TabIndex = 17;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(183, 68);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(84, 59);
            this.btnSquare.TabIndex = 19;
            this.btnSquare.Text = "^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(273, 68);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(84, 59);
            this.btnSqrt.TabIndex = 6;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(363, 68);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(84, 59);
            this.btnReciprocal.TabIndex = 11;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 133);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 59);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(93, 133);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 59);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(183, 133);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 59);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(273, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 59);
            this.button9.TabIndex = 8;
            this.button9.Text = "(";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(363, 133);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 59);
            this.button20.TabIndex = 9;
            this.button20.Text = ")";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 198);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 59);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(93, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 59);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(183, 198);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 59);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(273, 198);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(84, 59);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(363, 198);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(84, 59);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 263);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 59);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 263);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 59);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(183, 263);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 59);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(273, 263);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(84, 59);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(363, 263);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(84, 59);
            this.btnMultiply.TabIndex = 22;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Location = new System.Drawing.Point(3, 328);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(84, 59);
            this.btnNegate.TabIndex = 24;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(93, 328);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 59);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(183, 328);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(84, 59);
            this.btnDecimal.TabIndex = 21;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(273, 328);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(84, 59);
            this.btnAns.TabIndex = 20;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(363, 328);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(84, 59);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.click);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_old;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAns;
    }
}

