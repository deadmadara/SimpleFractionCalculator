
namespace SimpleFractionCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 29);
            this.textBox1.TabIndex = 0;
            // 
            // buttonC
            // 
            this.buttonC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonC.Location = new System.Drawing.Point(12, 47);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(35, 35);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonResult.Location = new System.Drawing.Point(53, 47);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(35, 35);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonHelp.Location = new System.Drawing.Point(94, 47);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 35);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 91);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(200, 160);
            this.Name = "Form1";
            this.Text = "/";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonHelp;
    }
}

