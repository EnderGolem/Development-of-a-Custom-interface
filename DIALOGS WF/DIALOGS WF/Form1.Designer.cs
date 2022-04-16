using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace DIALOGS_WF
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
            this.Twin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Twin
            // 
            this.Twin.Location = new System.Drawing.Point(307, 172);
            this.Twin.Name = "Twin";
            this.Twin.Size = new System.Drawing.Size(166, 57);
            this.Twin.TabIndex = 0;
            this.Twin.Text = "Twin";
            this.Twin.UseVisualStyleBackColor = true;
            this.Twin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 270);
            this.Controls.Add(this.Twin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        Form2 newForm2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (newForm2 == null || newForm2.IsDisposed)
            {
                newForm2 = new Form2();
                newForm2.Show();
                newForm2.Size = this.Size;
                newForm2.Ok.Location = new System.Drawing.Point(Size.Width / 2 - 100,Size.Height/2);
                newForm2.Cancel.Location = new System.Drawing.Point(Size.Width / 2 + 100, Size.Height / 2);
                newForm2.Sib = this;
            }

        }

        private System.Windows.Forms.Button Twin;
    }
}

