namespace cs성적계산기
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
            this.label1 = new System.Windows.Forms.Label();
            this.Korea = new System.Windows.Forms.TextBox();
            this.Math = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.GroupBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // Korea
            // 
            this.Korea.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.Korea.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Korea.Location = new System.Drawing.Point(202, 82);
            this.Korea.Name = "Korea";
            this.Korea.Size = new System.Drawing.Size(125, 27);
            this.Korea.TabIndex = 1;
            this.Korea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Math
            // 
            this.Math.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.Math.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Math.Location = new System.Drawing.Point(202, 138);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(125, 27);
            this.Math.TabIndex = 3;
            this.Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "수학";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // English
            // 
            this.English.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.English.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.English.Location = new System.Drawing.Point(202, 197);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(125, 27);
            this.English.TabIndex = 5;
            this.English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "영어";
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(102, 40);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(268, 227);
            this.score.TabIndex = 6;
            this.score.TabStop = false;
            this.score.Text = "성적 입력";
            this.score.Enter += new System.EventHandler(this.score_Enter);
            // 
            // txtAvg
            // 
            this.txtAvg.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtAvg.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAvg.Location = new System.Drawing.Point(520, 138);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(125, 27);
            this.txtAvg.TabIndex = 10;
            this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(450, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "평균";
            // 
            // txtsum
            // 
            this.txtsum.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtsum.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsum.Location = new System.Drawing.Point(520, 82);
            this.txtsum.Name = "txtsum";
            this.txtsum.ReadOnly = true;
            this.txtsum.Size = new System.Drawing.Size(125, 27);
            this.txtsum.TabIndex = 8;
            this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(450, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "총점";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(420, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적 입력";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn.Location = new System.Drawing.Point(520, 210);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(125, 29);
            this.btn.TabIndex = 14;
            this.btn.Text = "계산";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 304);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.English);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Korea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Korea;
        private TextBox Math;
        private Label label2;
        private TextBox English;
        private Label label3;
        private GroupBox score;
        private TextBox txtAvg;
        private Label label5;
        private TextBox txtsum;
        private Label label6;
        private GroupBox groupBox1;
        private Button btn;
    }
}