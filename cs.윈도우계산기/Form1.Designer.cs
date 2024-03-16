namespace cs.윈도우계산기
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
            this.txtexp = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMc = new System.Windows.Forms.Button();
            this.btnMr = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMmius = new System.Windows.Forms.Button();
            this.btnMs = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnroute = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btndis = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMius = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPluss = new System.Windows.Forms.Button();
            this.btnPlusMius = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnOt = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtexp
            // 
            this.txtexp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtexp.Location = new System.Drawing.Point(26, 22);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(329, 20);
            this.txtexp.TabIndex = 0;
            this.txtexp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(26, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(329, 54);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnMc
            // 
            this.btnMc.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMc.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMc.Location = new System.Drawing.Point(26, 102);
            this.btnMc.Name = "btnMc";
            this.btnMc.Size = new System.Drawing.Size(61, 38);
            this.btnMc.TabIndex = 2;
            this.btnMc.Text = "MC";
            this.btnMc.UseVisualStyleBackColor = false;
            this.btnMc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMr
            // 
            this.btnMr.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMr.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMr.Location = new System.Drawing.Point(93, 102);
            this.btnMr.Name = "btnMr";
            this.btnMr.Size = new System.Drawing.Size(61, 38);
            this.btnMr.TabIndex = 2;
            this.btnMr.Text = "MR";
            this.btnMr.UseVisualStyleBackColor = false;
            this.btnMr.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(160, 102);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 38);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "M+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMmius
            // 
            this.btnMmius.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMmius.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMmius.Location = new System.Drawing.Point(227, 102);
            this.btnMmius.Name = "btnMmius";
            this.btnMmius.Size = new System.Drawing.Size(61, 38);
            this.btnMmius.TabIndex = 2;
            this.btnMmius.Text = "M-";
            this.btnMmius.UseVisualStyleBackColor = false;
            this.btnMmius.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMs
            // 
            this.btnMs.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMs.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMs.Location = new System.Drawing.Point(294, 102);
            this.btnMs.Name = "btnMs";
            this.btnMs.Size = new System.Drawing.Size(61, 38);
            this.btnMs.TabIndex = 2;
            this.btnMs.Text = "MS";
            this.btnMs.UseVisualStyleBackColor = false;
            this.btnMs.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPer
            // 
            this.btnPer.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPer.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPer.Location = new System.Drawing.Point(25, 146);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(78, 48);
            this.btnPer.TabIndex = 3;
            this.btnPer.Text = "%";
            this.btnPer.UseVisualStyleBackColor = false;
            this.btnPer.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnroute
            // 
            this.btnroute.BackColor = System.Drawing.SystemColors.Menu;
            this.btnroute.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnroute.Location = new System.Drawing.Point(109, 146);
            this.btnroute.Name = "btnroute";
            this.btnroute.Size = new System.Drawing.Size(78, 48);
            this.btnroute.TabIndex = 3;
            this.btnroute.Text = "√";
            this.btnroute.UseVisualStyleBackColor = false;
            this.btnroute.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSqr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqr.Location = new System.Drawing.Point(193, 146);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(78, 48);
            this.btnSqr.TabIndex = 3;
            this.btnSqr.Text = "x²";
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.SystemColors.Menu;
            this.btnx.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnx.Location = new System.Drawing.Point(277, 146);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(78, 48);
            this.btnx.TabIndex = 3;
            this.btnx.Text = " 1/x​";
            this.btnx.UseVisualStyleBackColor = false;
            this.btnx.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCE.Location = new System.Drawing.Point(25, 200);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(78, 48);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Menu;
            this.btnC.Location = new System.Drawing.Point(109, 200);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(78, 48);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.button11_Click);
            // 
            // btndis
            // 
            this.btndis.BackColor = System.Drawing.SystemColors.Menu;
            this.btndis.Location = new System.Drawing.Point(277, 200);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(78, 48);
            this.btndis.TabIndex = 3;
            this.btndis.Text = "÷";
            this.btndis.UseVisualStyleBackColor = false;
            this.btndis.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Menu;
            this.button13.Location = new System.Drawing.Point(193, 200);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 48);
            this.button13.TabIndex = 3;
            this.button13.Text = "⌫";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(25, 254);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 48);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(109, 254);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 48);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(193, 254);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 48);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMult.Location = new System.Drawing.Point(277, 254);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(78, 48);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(25, 308);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 48);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(109, 308);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 48);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(193, 308);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 48);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMius
            // 
            this.btnMius.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMius.Location = new System.Drawing.Point(277, 308);
            this.btnMius.Name = "btnMius";
            this.btnMius.Size = new System.Drawing.Size(78, 48);
            this.btnMius.TabIndex = 3;
            this.btnMius.Text = "－";
            this.btnMius.UseVisualStyleBackColor = false;
            this.btnMius.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 362);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 48);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(109, 362);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 48);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(193, 362);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 48);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPluss
            // 
            this.btnPluss.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPluss.Location = new System.Drawing.Point(277, 362);
            this.btnPluss.Name = "btnPluss";
            this.btnPluss.Size = new System.Drawing.Size(78, 48);
            this.btnPluss.TabIndex = 3;
            this.btnPluss.Text = "＋";
            this.btnPluss.UseVisualStyleBackColor = false;
            this.btnPluss.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnPlusMius
            // 
            this.btnPlusMius.Location = new System.Drawing.Point(25, 416);
            this.btnPlusMius.Name = "btnPlusMius";
            this.btnPlusMius.Size = new System.Drawing.Size(78, 48);
            this.btnPlusMius.TabIndex = 3;
            this.btnPlusMius.Text = "±";
            this.btnPlusMius.UseVisualStyleBackColor = true;
            this.btnPlusMius.Click += new System.EventHandler(this.btnPlusMius_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(109, 416);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(78, 48);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOt
            // 
            this.btnOt.Location = new System.Drawing.Point(193, 416);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(78, 48);
            this.btnOt.TabIndex = 3;
            this.btnOt.Text = ".";
            this.btnOt.UseVisualStyleBackColor = true;
            this.btnOt.Click += new System.EventHandler(this.button28_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.Menu;
            this.btnE.Location = new System.Drawing.Point(277, 416);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(78, 48);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "＝";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.button29_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(385, 483);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPluss);
            this.Controls.Add(this.btnMius);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btnOt);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btndis);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnPlusMius);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnroute);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnMs);
            this.Controls.Add(this.btnMmius);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMr);
            this.Controls.Add(this.btnMc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtexp);
            this.Name = "Form1";
            this.Text = "윈도우 표준 계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtexp;
        private TextBox txtResult;
        private Button btnMc;
        private Button btnMr;
        private Button btnPlus;
        private Button btnMmius;
        private Button btnMs;
        private Button btnPer;
        private Button btnroute;
        private Button btnSqr;
        private Button btnx;
        private Button btnCE;
        private Button btnC;
        private Button btndis;
        private Button button13;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMult;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMius;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPluss;
        private Button btnPlusMius;
        private Button btn0;
        private Button btnOt;
        private Button btnE;
    }
}