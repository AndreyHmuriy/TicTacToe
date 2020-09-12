namespace TicTacToe_WinForms_MVP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 41);
            this.panel2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(507, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btn9);
            this.pnlButtons.Controls.Add(this.btn8);
            this.pnlButtons.Controls.Add(this.btn7);
            this.pnlButtons.Controls.Add(this.btn6);
            this.pnlButtons.Controls.Add(this.btn5);
            this.pnlButtons.Controls.Add(this.btn4);
            this.pnlButtons.Controls.Add(this.btn3);
            this.pnlButtons.Controls.Add(this.btn2);
            this.pnlButtons.Controls.Add(this.btn1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(619, 620);
            this.pnlButtons.TabIndex = 2;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(415, 415);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(200, 200);
            this.btn9.TabIndex = 10;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(209, 415);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(200, 200);
            this.btn8.TabIndex = 9;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 415);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(200, 200);
            this.btn7.TabIndex = 8;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(415, 209);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(200, 200);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(209, 209);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(200, 200);
            this.btn5.TabIndex = 6;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 209);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(200, 200);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(415, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 200);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(209, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 200);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 200);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlButtons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

