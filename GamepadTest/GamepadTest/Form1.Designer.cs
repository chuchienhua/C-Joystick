namespace GamepadTest
{
    partial class Form1
    {
   
        /// <summary>
        ///所需的介面宣告。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///清理所有正在使用的資源。
        /// </ summary>
        /// <param name =“disposing”>如果應刪除託管資源，則為true;否則為false。</ param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 頁面自動生成的代碼

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lbJoystick = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblRight2 = new System.Windows.Forms.Label();
            this.lblLeft2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.RC = new System.Windows.Forms.Label();
            this.LC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(13, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(13, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(319, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 220);
            this.panel2.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(13, 618);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(526, 100);
            this.txtMessage.TabIndex = 4;
            // 
            // lbJoystick
            // 
            this.lbJoystick.AutoSize = true;
            this.lbJoystick.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbJoystick.Location = new System.Drawing.Point(12, 9);
            this.lbJoystick.Name = "lbJoystick";
            this.lbJoystick.Size = new System.Drawing.Size(39, 48);
            this.lbJoystick.TabIndex = 5;
            this.lbJoystick.Text = "a";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 508);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 81);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 508);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 81);
            this.textBox2.TabIndex = 7;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblY.Location = new System.Drawing.Point(416, 154);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(40, 48);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblX.Location = new System.Drawing.Point(376, 194);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(42, 48);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "X";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.lblA.Location = new System.Drawing.Point(416, 234);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 48);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblB.Location = new System.Drawing.Point(456, 194);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(41, 48);
            this.lblB.TabIndex = 11;
            this.lblB.Text = "B";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(24, 99);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(95, 32);
            this.lblLeft.TabIndex = 12;
            this.lblLeft.Text = "Left UP";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(435, 99);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(111, 32);
            this.lblRight.TabIndex = 13;
            this.lblRight.Text = "Right UP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(185, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 30);
            this.panel3.TabIndex = 14;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(85, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblRight2
            // 
            this.lblRight2.AutoSize = true;
            this.lblRight2.Location = new System.Drawing.Point(435, 64);
            this.lblRight2.Name = "lblRight2";
            this.lblRight2.Size = new System.Drawing.Size(151, 32);
            this.lblRight2.TabIndex = 16;
            this.lblRight2.Text = "Right  Down";
            // 
            // lblLeft2
            // 
            this.lblLeft2.AutoSize = true;
            this.lblLeft2.Location = new System.Drawing.Point(24, 64);
            this.lblLeft2.Name = "lblLeft2";
            this.lblLeft2.Size = new System.Drawing.Size(127, 32);
            this.lblLeft2.TabIndex = 15;
            this.lblLeft2.Text = "Left Down";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start.Location = new System.Drawing.Point(291, 194);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 48);
            this.start.TabIndex = 18;
            this.start.Text = "start";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back.Location = new System.Drawing.Point(209, 194);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(96, 48);
            this.back.TabIndex = 17;
            this.back.Text = "back";
            // 
            // RC
            // 
            this.RC.AutoSize = true;
            this.RC.Location = new System.Drawing.Point(388, 592);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(151, 32);
            this.RC.TabIndex = 20;
            this.RC.Text = "Right Center";
            // 
            // LC
            // 
            this.LC.AutoSize = true;
            this.LC.Location = new System.Drawing.Point(82, 592);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(135, 32);
            this.LC.TabIndex = 19;
            this.LC.Text = "Left Center";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 730);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.start);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lblRight2);
            this.Controls.Add(this.lblLeft2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbJoystick);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lbJoystick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblRight2;
        private System.Windows.Forms.Label lblLeft2;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label RC;
        private System.Windows.Forms.Label LC;
    }
}

