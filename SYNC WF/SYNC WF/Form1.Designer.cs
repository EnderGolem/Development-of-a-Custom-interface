
namespace SYNC_WF
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
            this.color1 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Label();
            this.color3 = new System.Windows.Forms.Label();
            this.color4 = new System.Windows.Forms.Label();
            this.color5 = new System.Windows.Forms.Label();
            this.color6 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // color1
            // 
            this.color1.AutoSize = true;
            this.color1.Location = new System.Drawing.Point(65, 49);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(43, 13);
            this.color1.TabIndex = 0;
            this.color1.Text = "Colour1";
            this.color1.Click += new System.EventHandler(this.label1_Click);
            // 
            // color2
            // 
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(65, 62);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(43, 13);
            this.color2.TabIndex = 1;
            this.color2.Text = "Colour2";
            // 
            // color3
            // 
            this.color3.AutoSize = true;
            this.color3.Location = new System.Drawing.Point(65, 75);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(43, 13);
            this.color3.TabIndex = 2;
            this.color3.Text = "Colour3";
            // 
            // color4
            // 
            this.color4.AutoSize = true;
            this.color4.Location = new System.Drawing.Point(65, 88);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(43, 13);
            this.color4.TabIndex = 3;
            this.color4.Text = "Colour4";
            // 
            // color5
            // 
            this.color5.AutoSize = true;
            this.color5.Location = new System.Drawing.Point(65, 101);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(43, 13);
            this.color5.TabIndex = 4;
            this.color5.Text = "Colour5";
            // 
            // color6
            // 
            this.color6.AutoSize = true;
            this.color6.Location = new System.Drawing.Point(65, 114);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(43, 13);
            this.color6.TabIndex = 5;
            this.color6.Text = "Colour6";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(529, 203);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 6;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.MouseClick += new System.Windows.Forms.MouseEventHandler(this.show_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.color6);
            this.Controls.Add(this.color5);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label color1;
        private System.Windows.Forms.Label color2;
        private System.Windows.Forms.Label color3;
        private System.Windows.Forms.Label color4;
        private System.Windows.Forms.Label color5;
        private System.Windows.Forms.Label color6;
        private System.Windows.Forms.Button show;
    }
}

