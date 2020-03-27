namespace Youtube0._2
{
    partial class Youtube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youtube));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вТрендеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подпискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вашиВидеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.вТрендеToolStripMenuItem,
            this.подпискиToolStripMenuItem,
            this.библиоToolStripMenuItem,
            this.историяToolStripMenuItem,
            this.вашиВидеоToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // вТрендеToolStripMenuItem
            // 
            this.вТрендеToolStripMenuItem.Name = "вТрендеToolStripMenuItem";
            this.вТрендеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вТрендеToolStripMenuItem.Text = "В тренде";
            this.вТрендеToolStripMenuItem.Click += new System.EventHandler(this.вТрендеToolStripMenuItem_Click);
            // 
            // подпискиToolStripMenuItem
            // 
            this.подпискиToolStripMenuItem.Name = "подпискиToolStripMenuItem";
            this.подпискиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.подпискиToolStripMenuItem.Text = "Подписки";
            this.подпискиToolStripMenuItem.Click += new System.EventHandler(this.подпискиToolStripMenuItem_Click);
            // 
            // библиоToolStripMenuItem
            // 
            this.библиоToolStripMenuItem.Name = "библиоToolStripMenuItem";
            this.библиоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.библиоToolStripMenuItem.Text = "Библиотека";
            this.библиоToolStripMenuItem.Click += new System.EventHandler(this.библиоToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // вашиВидеоToolStripMenuItem
            // 
            this.вашиВидеоToolStripMenuItem.Name = "вашиВидеоToolStripMenuItem";
            this.вашиВидеоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вашиВидеоToolStripMenuItem.Text = "Ваши видео";
            this.вашиВидеоToolStripMenuItem.Click += new System.EventHandler(this.вашиВидеоToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "О мне";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(815, 450);
            this.webBrowser1.TabIndex = 6;
            // 
            // Youtube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(815, 474);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Youtube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вТрендеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подпискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вашиВидеоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

