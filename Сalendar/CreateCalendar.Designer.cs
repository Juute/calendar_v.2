namespace Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьКалендарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.календарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заметкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1126, 582);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКалендарьToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьКалендарьToolStripMenuItem
            // 
            this.создатьКалендарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГодToolStripMenuItem,
            this.наМесяцToolStripMenuItem,
            this.наДеньToolStripMenuItem});
            this.создатьКалендарьToolStripMenuItem.Name = "создатьКалендарьToolStripMenuItem";
            this.создатьКалендарьToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.создатьКалендарьToolStripMenuItem.Text = "Создать календарь";
            // 
            // наГодToolStripMenuItem
            // 
            this.наГодToolStripMenuItem.Name = "наГодToolStripMenuItem";
            this.наГодToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.наГодToolStripMenuItem.Text = "На год";
            this.наГодToolStripMenuItem.Click += new System.EventHandler(this.наГодToolStripMenuItem_Click);
            // 
            // наМесяцToolStripMenuItem
            // 
            this.наМесяцToolStripMenuItem.Name = "наМесяцToolStripMenuItem";
            this.наМесяцToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.наМесяцToolStripMenuItem.Text = "На месяц";
            this.наМесяцToolStripMenuItem.Click += new System.EventHandler(this.наМесяцToolStripMenuItem_Click);
            // 
            // наДеньToolStripMenuItem
            // 
            this.наДеньToolStripMenuItem.Name = "наДеньToolStripMenuItem";
            this.наДеньToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.наДеньToolStripMenuItem.Text = "На день";
            this.наДеньToolStripMenuItem.Click += new System.EventHandler(this.наДеньToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.календарьToolStripMenuItem,
            this.заметкиToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.печатьToolStripMenuItem.Text = "Сохранить на печать";
            // 
            // календарьToolStripMenuItem
            // 
            this.календарьToolStripMenuItem.Name = "календарьToolStripMenuItem";
            this.календарьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.календарьToolStripMenuItem.Text = "Календарь";
            this.календарьToolStripMenuItem.Click += new System.EventHandler(this.календарьToolStripMenuItem_Click);
            // 
            // заметкиToolStripMenuItem
            // 
            this.заметкиToolStripMenuItem.Name = "заметкиToolStripMenuItem";
            this.заметкиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.заметкиToolStripMenuItem.Text = "Заметки";
            this.заметкиToolStripMenuItem.Click += new System.EventHandler(this.заметкиToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Календарь на 2018 год";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Календарь";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьКалендарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наДеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem календарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заметкиToolStripMenuItem;
    }
}

