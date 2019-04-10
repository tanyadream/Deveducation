namespace Calculate
{
    partial class fCalc
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
            this.components = new System.ComponentModel.Container();
            this.bsin = new System.Windows.Forms.Button();
            this.bCos = new System.Windows.Forms.Button();
            this.bTg = new System.Windows.Forms.Button();
            this.bCtg = new System.Windows.Forms.Button();
            this.bAbs = new System.Windows.Forms.Button();
            this.bLn = new System.Windows.Forms.Button();
            this.bExp = new System.Windows.Forms.Button();
            this.bx_y = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bX_in2 = new System.Windows.Forms.Button();
            this.b1_x = new System.Windows.Forms.Button();
            this.bFact = new System.Windows.Forms.Button();
            this.bNum1 = new System.Windows.Forms.Button();
            this.bNum4 = new System.Windows.Forms.Button();
            this.bNum2 = new System.Windows.Forms.Button();
            this.bNum3 = new System.Windows.Forms.Button();
            this.bNum5 = new System.Windows.Forms.Button();
            this.bNum6 = new System.Windows.Forms.Button();
            this.bNum8 = new System.Windows.Forms.Button();
            this.bNum7 = new System.Windows.Forms.Button();
            this.bNum9 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bNum0 = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bRavno = new System.Windows.Forms.Button();
            this.bUmn = new System.Windows.Forms.Button();
            this.bDelenie = new System.Windows.Forms.Button();
            this.tb_Calc = new System.Windows.Forms.TextBox();
            this.bSvoistva = new System.Windows.Forms.Button();
            this.Anim = new System.Windows.Forms.Timer(this.components);
            this.Sqrt = new System.Windows.Forms.Button();
            this.bksp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsin
            // 
            this.bsin.Location = new System.Drawing.Point(307, 94);
            this.bsin.Name = "bsin";
            this.bsin.Size = new System.Drawing.Size(40, 37);
            this.bsin.TabIndex = 0;
            this.bsin.Text = "sin(x)";
            this.bsin.UseVisualStyleBackColor = true;
            this.bsin.Click += new System.EventHandler(this.bsin_Click);
            // 
            // bCos
            // 
            this.bCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCos.Location = new System.Drawing.Point(353, 94);
            this.bCos.Name = "bCos";
            this.bCos.Size = new System.Drawing.Size(40, 37);
            this.bCos.TabIndex = 1;
            this.bCos.Text = "cos(x)";
            this.bCos.UseVisualStyleBackColor = true;
            this.bCos.Click += new System.EventHandler(this.bCos_Click);
            // 
            // bTg
            // 
            this.bTg.Location = new System.Drawing.Point(399, 94);
            this.bTg.Name = "bTg";
            this.bTg.Size = new System.Drawing.Size(40, 37);
            this.bTg.TabIndex = 2;
            this.bTg.Text = "tg(x)";
            this.bTg.UseVisualStyleBackColor = true;
            this.bTg.Click += new System.EventHandler(this.bTg_Click);
            // 
            // bCtg
            // 
            this.bCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCtg.Location = new System.Drawing.Point(307, 137);
            this.bCtg.Name = "bCtg";
            this.bCtg.Size = new System.Drawing.Size(40, 37);
            this.bCtg.TabIndex = 3;
            this.bCtg.Text = "ctg(x)";
            this.bCtg.UseVisualStyleBackColor = true;
            this.bCtg.Click += new System.EventHandler(this.bCtg_Click);
            // 
            // bAbs
            // 
            this.bAbs.Location = new System.Drawing.Point(353, 137);
            this.bAbs.Name = "bAbs";
            this.bAbs.Size = new System.Drawing.Size(40, 37);
            this.bAbs.TabIndex = 4;
            this.bAbs.Text = "|x|";
            this.bAbs.UseVisualStyleBackColor = true;
            this.bAbs.Click += new System.EventHandler(this.bAbs_Click);
            // 
            // bLn
            // 
            this.bLn.Location = new System.Drawing.Point(399, 137);
            this.bLn.Name = "bLn";
            this.bLn.Size = new System.Drawing.Size(40, 37);
            this.bLn.TabIndex = 5;
            this.bLn.Text = "ln(x)";
            this.bLn.UseVisualStyleBackColor = true;
            this.bLn.Click += new System.EventHandler(this.bLn_Click);
            // 
            // bExp
            // 
            this.bExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExp.Location = new System.Drawing.Point(307, 180);
            this.bExp.Name = "bExp";
            this.bExp.Size = new System.Drawing.Size(40, 37);
            this.bExp.TabIndex = 6;
            this.bExp.Text = "exp(x)";
            this.bExp.UseVisualStyleBackColor = true;
            this.bExp.Click += new System.EventHandler(this.bExp_Click);
            // 
            // bx_y
            // 
            this.bx_y.Location = new System.Drawing.Point(353, 180);
            this.bx_y.Name = "bx_y";
            this.bx_y.Size = new System.Drawing.Size(40, 37);
            this.bx_y.TabIndex = 7;
            this.bx_y.Text = "x^y";
            this.bx_y.UseVisualStyleBackColor = true;
            this.bx_y.Click += new System.EventHandler(this.bx_y_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSqrt.Location = new System.Drawing.Point(399, 180);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(40, 37);
            this.bSqrt.TabIndex = 8;
            this.bSqrt.Text = "sqrt(x)";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bX_in2
            // 
            this.bX_in2.Location = new System.Drawing.Point(307, 223);
            this.bX_in2.Name = "bX_in2";
            this.bX_in2.Size = new System.Drawing.Size(40, 37);
            this.bX_in2.TabIndex = 9;
            this.bX_in2.Text = "x^2";
            this.bX_in2.UseVisualStyleBackColor = true;
            this.bX_in2.Click += new System.EventHandler(this.bX_in2_Click);
            // 
            // b1_x
            // 
            this.b1_x.Location = new System.Drawing.Point(353, 223);
            this.b1_x.Name = "b1_x";
            this.b1_x.Size = new System.Drawing.Size(40, 37);
            this.b1_x.TabIndex = 10;
            this.b1_x.Text = "1/x";
            this.b1_x.UseVisualStyleBackColor = true;
            this.b1_x.Click += new System.EventHandler(this.b1_x_Click);
            // 
            // bFact
            // 
            this.bFact.Location = new System.Drawing.Point(399, 223);
            this.bFact.Name = "bFact";
            this.bFact.Size = new System.Drawing.Size(40, 37);
            this.bFact.TabIndex = 11;
            this.bFact.Text = "n!";
            this.bFact.UseVisualStyleBackColor = true;
            this.bFact.Click += new System.EventHandler(this.bFact_Click);
            // 
            // bNum1
            // 
            this.bNum1.Location = new System.Drawing.Point(12, 94);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(40, 37);
            this.bNum1.TabIndex = 12;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = true;
            this.bNum1.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum4
            // 
            this.bNum4.Location = new System.Drawing.Point(12, 137);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(40, 37);
            this.bNum4.TabIndex = 13;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = true;
            this.bNum4.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum2
            // 
            this.bNum2.Location = new System.Drawing.Point(58, 94);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(40, 37);
            this.bNum2.TabIndex = 14;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = true;
            this.bNum2.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum3
            // 
            this.bNum3.Location = new System.Drawing.Point(104, 94);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(40, 37);
            this.bNum3.TabIndex = 15;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = true;
            this.bNum3.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum5
            // 
            this.bNum5.Location = new System.Drawing.Point(58, 137);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(40, 37);
            this.bNum5.TabIndex = 16;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = true;
            this.bNum5.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum6
            // 
            this.bNum6.Location = new System.Drawing.Point(104, 137);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(40, 37);
            this.bNum6.TabIndex = 17;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = true;
            this.bNum6.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum8
            // 
            this.bNum8.Location = new System.Drawing.Point(60, 180);
            this.bNum8.Name = "bNum8";
            this.bNum8.Size = new System.Drawing.Size(40, 37);
            this.bNum8.TabIndex = 18;
            this.bNum8.Text = "8";
            this.bNum8.UseVisualStyleBackColor = true;
            this.bNum8.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum7
            // 
            this.bNum7.Location = new System.Drawing.Point(14, 180);
            this.bNum7.Name = "bNum7";
            this.bNum7.Size = new System.Drawing.Size(40, 37);
            this.bNum7.TabIndex = 19;
            this.bNum7.Text = "7";
            this.bNum7.UseVisualStyleBackColor = true;
            this.bNum7.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bNum9
            // 
            this.bNum9.Location = new System.Drawing.Point(104, 180);
            this.bNum9.Name = "bNum9";
            this.bNum9.Size = new System.Drawing.Size(40, 37);
            this.bNum9.TabIndex = 20;
            this.bNum9.Text = "9";
            this.bNum9.UseVisualStyleBackColor = true;
            this.bNum9.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(14, 223);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(40, 37);
            this.bClear.TabIndex = 21;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bNum0
            // 
            this.bNum0.Location = new System.Drawing.Point(60, 223);
            this.bNum0.Name = "bNum0";
            this.bNum0.Size = new System.Drawing.Size(40, 37);
            this.bNum0.TabIndex = 22;
            this.bNum0.Text = "0";
            this.bNum0.UseVisualStyleBackColor = true;
            this.bNum0.Click += new System.EventHandler(this.bNum1_Click);
            // 
            // bPoint
            // 
            this.bPoint.Location = new System.Drawing.Point(104, 223);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(40, 37);
            this.bPoint.TabIndex = 23;
            this.bPoint.Text = ",";
            this.bPoint.UseVisualStyleBackColor = true;
            this.bPoint.Click += new System.EventHandler(this.bPoint_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(181, 94);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(40, 37);
            this.bPlus.TabIndex = 24;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(181, 137);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(40, 37);
            this.bMinus.TabIndex = 25;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bRavno
            // 
            this.bRavno.Location = new System.Drawing.Point(227, 180);
            this.bRavno.Name = "bRavno";
            this.bRavno.Size = new System.Drawing.Size(40, 80);
            this.bRavno.TabIndex = 26;
            this.bRavno.Text = "=";
            this.bRavno.UseVisualStyleBackColor = true;
            this.bRavno.Click += new System.EventHandler(this.bRavno_Click);
            // 
            // bUmn
            // 
            this.bUmn.Location = new System.Drawing.Point(181, 180);
            this.bUmn.Name = "bUmn";
            this.bUmn.Size = new System.Drawing.Size(40, 37);
            this.bUmn.TabIndex = 27;
            this.bUmn.Text = "*";
            this.bUmn.UseVisualStyleBackColor = true;
            this.bUmn.Click += new System.EventHandler(this.bUmn_Click);
            // 
            // bDelenie
            // 
            this.bDelenie.Location = new System.Drawing.Point(181, 223);
            this.bDelenie.Name = "bDelenie";
            this.bDelenie.Size = new System.Drawing.Size(40, 37);
            this.bDelenie.TabIndex = 28;
            this.bDelenie.Text = "/";
            this.bDelenie.UseVisualStyleBackColor = true;
            this.bDelenie.Click += new System.EventHandler(this.bDelenie_Click);
            // 
            // tb_Calc
            // 
            this.tb_Calc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Calc.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_Calc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Calc.Location = new System.Drawing.Point(14, 29);
            this.tb_Calc.Name = "tb_Calc";
            this.tb_Calc.Size = new System.Drawing.Size(253, 29);
            this.tb_Calc.TabIndex = 29;
            this.tb_Calc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Calc_KeyPress);
            // 
            // bSvoistva
            // 
            this.bSvoistva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSvoistva.Font = new System.Drawing.Font("MT Extra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bSvoistva.ForeColor = System.Drawing.Color.Salmon;
            this.bSvoistva.Location = new System.Drawing.Point(273, 153);
            this.bSvoistva.Name = "bSvoistva";
            this.bSvoistva.Size = new System.Drawing.Size(28, 49);
            this.bSvoistva.TabIndex = 31;
            this.bSvoistva.Text = ">";
            this.bSvoistva.UseVisualStyleBackColor = false;
            this.bSvoistva.Click += new System.EventHandler(this.bSvoistva_Click);
            // 
            // Anim
            // 
            this.Anim.Enabled = true;
            this.Anim.Interval = 150;
            this.Anim.Tick += new System.EventHandler(this.Anim_Tick);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(228, 137);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(39, 37);
            this.Sqrt.TabIndex = 32;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // bksp
            // 
            this.bksp.Location = new System.Drawing.Point(228, 94);
            this.bksp.Name = "bksp";
            this.bksp.Size = new System.Drawing.Size(39, 37);
            this.bksp.TabIndex = 33;
            this.bksp.Text = "<--";
            this.bksp.UseVisualStyleBackColor = true;
            this.bksp.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(289, 266);
            this.Controls.Add(this.bksp);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.bTg);
            this.Controls.Add(this.bSvoistva);
            this.Controls.Add(this.bsin);
            this.Controls.Add(this.bCos);
            this.Controls.Add(this.bCtg);
            this.Controls.Add(this.tb_Calc);
            this.Controls.Add(this.bAbs);
            this.Controls.Add(this.bDelenie);
            this.Controls.Add(this.bLn);
            this.Controls.Add(this.bUmn);
            this.Controls.Add(this.bExp);
            this.Controls.Add(this.bRavno);
            this.Controls.Add(this.bx_y);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bX_in2);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.b1_x);
            this.Controls.Add(this.bNum0);
            this.Controls.Add(this.bFact);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bNum9);
            this.Controls.Add(this.bNum7);
            this.Controls.Add(this.bNum8);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.bNum5);
            this.Controls.Add(this.bNum3);
            this.Controls.Add(this.bNum2);
            this.Controls.Add(this.bNum4);
            this.Controls.Add(this.bNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.fCalc_Load);
            this.LocationChanged += new System.EventHandler(this.fCalc_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsin;
        private System.Windows.Forms.Button bCos;
        private System.Windows.Forms.Button bTg;
        private System.Windows.Forms.Button bCtg;
        private System.Windows.Forms.Button bAbs;
        private System.Windows.Forms.Button bLn;
        private System.Windows.Forms.Button bExp;
        private System.Windows.Forms.Button bx_y;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bX_in2;
        private System.Windows.Forms.Button b1_x;
        private System.Windows.Forms.Button bFact;
        private System.Windows.Forms.Button bNum1;
        private System.Windows.Forms.Button bNum4;
        private System.Windows.Forms.Button bNum2;
        private System.Windows.Forms.Button bNum3;
        private System.Windows.Forms.Button bNum5;
        private System.Windows.Forms.Button bNum6;
        private System.Windows.Forms.Button bNum8;
        private System.Windows.Forms.Button bNum7;
        private System.Windows.Forms.Button bNum9;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bNum0;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bRavno;
        private System.Windows.Forms.Button bUmn;
        private System.Windows.Forms.Button bDelenie;
        private System.Windows.Forms.TextBox tb_Calc;
        private System.Windows.Forms.Button bSvoistva;
        private System.Windows.Forms.Timer Anim;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button bksp;
    }
}

