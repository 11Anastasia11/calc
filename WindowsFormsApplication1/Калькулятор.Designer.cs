namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Term = new System.Windows.Forms.TextBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonCm = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonPropr = new System.Windows.Forms.Button();
            this.buttonProc = new System.Windows.Forms.Button();
            this.buttonPlusM = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(109, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 25);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 25);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(109, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 25);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Term
            // 
            this.Term.Location = new System.Drawing.Point(12, 12);
            this.Term.Multiline = true;
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(243, 64);
            this.Term.TabIndex = 9;
            this.Term.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Term.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(161, 238);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(31, 25);
            this.buttonMinus.TabIndex = 10;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(35, 270);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 25);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(161, 176);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(31, 25);
            this.buttonDiv.TabIndex = 12;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(161, 207);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(31, 25);
            this.buttonMult.TabIndex = 13;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Location = new System.Drawing.Point(161, 270);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(31, 25);
            this.buttonplus.TabIndex = 14;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonCm
            // 
            this.buttonCm.Location = new System.Drawing.Point(109, 269);
            this.buttonCm.Name = "buttonCm";
            this.buttonCm.Size = new System.Drawing.Size(31, 25);
            this.buttonCm.TabIndex = 15;
            this.buttonCm.Text = ",";
            this.buttonCm.UseVisualStyleBackColor = true;
            this.buttonCm.Click += new System.EventHandler(this.buttoncm_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(198, 238);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(33, 57);
            this.buttonResult.TabIndex = 16;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonPropr
            // 
            this.buttonPropr.Location = new System.Drawing.Point(200, 207);
            this.buttonPropr.Name = "buttonPropr";
            this.buttonPropr.Size = new System.Drawing.Size(31, 25);
            this.buttonPropr.TabIndex = 17;
            this.buttonPropr.Text = "1/x";
            this.buttonPropr.UseVisualStyleBackColor = true;
            this.buttonPropr.Click += new System.EventHandler(this.buttonPropr_Click);
            // 
            // buttonProc
            // 
            this.buttonProc.Location = new System.Drawing.Point(200, 176);
            this.buttonProc.Name = "buttonProc";
            this.buttonProc.Size = new System.Drawing.Size(31, 25);
            this.buttonProc.TabIndex = 18;
            this.buttonProc.Text = "%";
            this.buttonProc.UseVisualStyleBackColor = true;
            this.buttonProc.Click += new System.EventHandler(this.buttonProc_Click);
            // 
            // buttonPlusM
            // 
            this.buttonPlusM.Location = new System.Drawing.Point(161, 145);
            this.buttonPlusM.Name = "buttonPlusM";
            this.buttonPlusM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonPlusM.Size = new System.Drawing.Size(31, 25);
            this.buttonPlusM.TabIndex = 19;
            this.buttonPlusM.Text = "±";
            this.buttonPlusM.UseVisualStyleBackColor = true;
            this.buttonPlusM.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(198, 145);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSqrt.Size = new System.Drawing.Size(31, 25);
            this.buttonSqrt.TabIndex = 20;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.Location = new System.Drawing.Point(198, 114);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(31, 25);
            this.buttonMMinus.TabIndex = 21;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = true;
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Location = new System.Drawing.Point(161, 114);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(31, 25);
            this.buttonMPlus.TabIndex = 22;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.Location = new System.Drawing.Point(109, 114);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(31, 25);
            this.buttonMS.TabIndex = 23;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMR.Location = new System.Drawing.Point(72, 113);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(31, 26);
            this.buttonMR.TabIndex = 24;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(35, 114);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(31, 25);
            this.buttonMC.TabIndex = 25;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(109, 145);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(31, 25);
            this.buttonC.TabIndex = 26;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(72, 145);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(31, 25);
            this.buttonCE.TabIndex = 27;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(35, 145);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(31, 25);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(32, 46);
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result.Size = new System.Drawing.Size(218, 21);
            this.Result.TabIndex = 30;
            this.Result.Text = "        0  ";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Memory.Location = new System.Drawing.Point(35, 50);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(43, 13);
            this.Memory.TabIndex = 31;
            this.Memory.Text = "            ";
            this.Memory.Click += new System.EventHandler(this.Memory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 324);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPlusM);
            this.Controls.Add(this.buttonProc);
            this.Controls.Add(this.buttonPropr);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonCm);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox Term;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonCm;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonPropr;
        private System.Windows.Forms.Button buttonProc;
        private System.Windows.Forms.Button buttonPlusM;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Memory;
    }
}

