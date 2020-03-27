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
        string lang  = "rus";
        string aboutrus = "Программа разработана программистом Temnij_Chudak \n Версия 0.0.2";
        string abouteng = "This programmm developed by Temnij_Chudak \n Version 0.0.2";



        public Youtube()
        {
            InitializeComponent();

            webBrowser1.Navigate("youtube.com");

        }

   

        
        private void библиоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/feed/library");
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
            if (lang.Equals("rus"))
            {
                MessageBox.Show(aboutrus,"О мне");
            }
            else
            {
                MessageBox.Show(abouteng,"About");
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
        }

        private void вТрендеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/feed/trending");
        }

        private void подпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/feed/subscriptions");
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/feed/history");
        }

        private void вашиВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/feed/my_videos");
        }
    }
}
