
namespace Lab7._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.RichTextBox_OutPut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число:";
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Input.Location = new System.Drawing.Point(138, 30);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(129, 20);
            this.TextBox_Input.TabIndex = 1;
            this.TextBox_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Button_Start
            // 
            this.Button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Start.Location = new System.Drawing.Point(283, 28);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(106, 23);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Начать расчет";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // RichTextBox_OutPut
            // 
            this.RichTextBox_OutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RichTextBox_OutPut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBox_OutPut.Location = new System.Drawing.Point(0, 79);
            this.RichTextBox_OutPut.Name = "RichTextBox_OutPut";
            this.RichTextBox_OutPut.ReadOnly = true;
            this.RichTextBox_OutPut.Size = new System.Drawing.Size(412, 138);
            this.RichTextBox_OutPut.TabIndex = 3;
            this.RichTextBox_OutPut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 217);
            this.Controls.Add(this.RichTextBox_OutPut);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.TextBox_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Последовательность чисел по алгоритму Эратосфена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.RichTextBox RichTextBox_OutPut;
    }
}

