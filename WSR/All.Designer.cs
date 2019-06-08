namespace WSR
{
    partial class All
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.итоговойРазмерПлатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.итоговойРазмерПлатыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.входToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.входToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.входToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.входToolStripMenuItem.Text = "Акаунт";
            // 
            // итоговойРазмерПлатыToolStripMenuItem
            // 
            this.итоговойРазмерПлатыToolStripMenuItem.Name = "итоговойРазмерПлатыToolStripMenuItem";
            this.итоговойРазмерПлатыToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.итоговойРазмерПлатыToolStripMenuItem.Text = "Итоговой размер платы";
            this.итоговойРазмерПлатыToolStripMenuItem.Click += new System.EventHandler(this.итоговойРазмерПлатыToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem1
            // 
            this.входToolStripMenuItem1.Name = "входToolStripMenuItem1";
            this.входToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.входToolStripMenuItem1.Text = "Вход";
            this.входToolStripMenuItem1.Click += new System.EventHandler(this.входToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 473);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "All";
            this.Text = "All";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem итоговойРазмерПлатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

