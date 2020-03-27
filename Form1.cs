using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube0._2
{
    public partial class Youtube : Form
    {
        bool flag = true;
        string lang;



        public Youtube()
        {
            InitializeComponent();
         
        }

   

        
        private void библиоToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.webBrowser1.Url = new System.Uri("https://www.youtube.com/feed/library", System.UriKind.Absolute);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YSettings set = new YSettings(lang);
            set.ShowDialog();
            this.lang = set.lang;
            if (lang.Equals("eng"))
            {
                главнаяToolStripMenuItem.Text = "Home";
                вТрендеToolStripMenuItem.Text = "In Trend";
                подпискиToolStripMenuItem.Text = "Subscribes";
                библиоToolStripMenuItem.Text = "Library";
                историяToolStripMenuItem.Text = "History";
                вашиВидеоToolStripMenuItem.Text = "Your Videos";
                menuToolStripMenuItem.Text = "Menu";
                aboutToolStripMenuItem.Text = "About";
                settingsToolStripMenuItem.Text = "Settings";
            }
            else
            {
                главнаяToolStripMenuItem.Text = "Главная";
                вТрендеToolStripMenuItem.Text = "В тренде";
                подпискиToolStripMenuItem.Text = "Подписки";
                библиоToolStripMenuItem.Text = "Библиотека";
                историяToolStripMenuItem.Text = "История";
                вашиВидеоToolStripMenuItem.Text = "Ваши видео";
                menuToolStripMenuItem.Text = "Меню";
                aboutToolStripMenuItem.Text = "О мне";
                settingsToolStripMenuItem.Text = "Настройки";
            }
                

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("http://www.youtube.com", System.UriKind.Absolute);
        }

        private void вТрендеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/feed/trending", System.UriKind.Absolute);
        }

        private void подпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/feed/subscriptions", System.UriKind.Absolute);
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri("https://www.youtube.com/feed/history", System.UriKind.Absolute);
        }

        private void вашиВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 this.webBrowser1.Url = new System.Uri("https://www.youtube.com/feed/my_videos", System.UriKind.Absolute);
        }
    }
}
