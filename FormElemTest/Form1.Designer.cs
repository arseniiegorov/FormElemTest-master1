namespace FormElemTest
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbx_out = new System.Windows.Forms.RichTextBox();
            this.btn_color_change = new System.Windows.Forms.Button();
            this.tbx_color_start = new System.Windows.Forms.TextBox();
            this.tbx_color_end = new System.Windows.Forms.TextBox();
            this.tbx_word = new System.Windows.Forms.TextBox();
            this.tbx_start = new System.Windows.Forms.TextBox();
            this.tbx_end = new System.Windows.Forms.TextBox();
            this.tbx_target = new System.Windows.Forms.TextBox();
            this.btn_change_word = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbx_out
            // 
            this.rtbx_out.Location = new System.Drawing.Point(13, 13);
            this.rtbx_out.Margin = new System.Windows.Forms.Padding(4);
            this.rtbx_out.Name = "rtbx_out";
            this.rtbx_out.Size = new System.Drawing.Size(489, 528);
            this.rtbx_out.TabIndex = 0;
            this.rtbx_out.Text = "";
            // 
            // btn_color_change
            // 
            this.btn_color_change.Location = new System.Drawing.Point(510, 96);
            this.btn_color_change.Margin = new System.Windows.Forms.Padding(4);
            this.btn_color_change.Name = "btn_color_change";
            this.btn_color_change.Size = new System.Drawing.Size(195, 28);
            this.btn_color_change.TabIndex = 1;
            this.btn_color_change.Text = "Изменить цвет";
            this.btn_color_change.UseVisualStyleBackColor = true;
            this.btn_color_change.Click += new System.EventHandler(this.btn_color_change_Click);
            // 
            // tbx_color_start
            // 
            this.tbx_color_start.Location = new System.Drawing.Point(509, 41);
            this.tbx_color_start.Name = "tbx_color_start";
            this.tbx_color_start.Size = new System.Drawing.Size(56, 22);
            this.tbx_color_start.TabIndex = 4;
            // 
            // tbx_color_end
            // 
            this.tbx_color_end.Location = new System.Drawing.Point(571, 41);
            this.tbx_color_end.Name = "tbx_color_end";
            this.tbx_color_end.Size = new System.Drawing.Size(55, 22);
            this.tbx_color_end.TabIndex = 5;
            // 
            // tbx_word
            // 
            this.tbx_word.Location = new System.Drawing.Point(510, 39);
            this.tbx_word.Name = "tbx_word";
            this.tbx_word.Size = new System.Drawing.Size(196, 22);
            this.tbx_word.TabIndex = 2;
            this.tbx_word.Text = "Слово для замены";
            // 
            // tbx_start
            // 
            this.tbx_start.Location = new System.Drawing.Point(510, 67);
            this.tbx_start.Name = "tbx_start";
            this.tbx_start.Size = new System.Drawing.Size(100, 22);
            this.tbx_start.TabIndex = 3;
            this.tbx_start.Text = "Начало";
            // 
            // tbx_end
            // 
            this.tbx_end.Location = new System.Drawing.Point(616, 67);
            this.tbx_end.Name = "tbx_end";
            this.tbx_end.Size = new System.Drawing.Size(90, 22);
            this.tbx_end.TabIndex = 4;
            this.tbx_end.Text = "Конец";
            // 
            // tbx_target
            // 
            this.tbx_target.Location = new System.Drawing.Point(510, 131);
            this.tbx_target.Name = "tbx_target";
            this.tbx_target.Size = new System.Drawing.Size(196, 22);
            this.tbx_target.TabIndex = 5;
            this.tbx_target.Text = "Слово на замену";
            // 
            // btn_change_word
            // 
            this.btn_change_word.Location = new System.Drawing.Point(511, 160);
            this.btn_change_word.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change_word.Name = "btn_change_word";
            this.btn_change_word.Size = new System.Drawing.Size(195, 28);
            this.btn_change_word.TabIndex = 6;
            this.btn_change_word.Text = "Изменить слово";
            this.btn_change_word.UseVisualStyleBackColor = true;
            this.btn_change_word.Click += new System.EventHandler(this.btn_change_word_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(718, 554);
            this.Controls.Add(this.btn_change_word);
            this.Controls.Add(this.tbx_target);
            this.Controls.Add(this.tbx_end);
            this.Controls.Add(this.tbx_start);
            this.Controls.Add(this.tbx_word);
            this.Controls.Add(this.btn_color_change);
            this.Controls.Add(this.rtbx_out);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_change_word;

        private System.Windows.Forms.TextBox tbx_color_end;
        private System.Windows.Forms.TextBox tbx_color_start;
        private System.Windows.Forms.TextBox tbx_word;
        private System.Windows.Forms.TextBox tbx_start;
        private System.Windows.Forms.TextBox tbx_end;
        private System.Windows.Forms.TextBox tbx_target;

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_out;
        private System.Windows.Forms.Button btn_color_change;
    }
}

