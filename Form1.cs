using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;


namespace Youtube0._2
{
    public partial class Youtube : Form
    {
        private readonly bool flag = true;
        private string lang = "rus";
        private readonly string aboutrus = "Программа разработана программистом Temnij_Chudak \n Версия 0.0.4";
        private readonly string abouteng = "This programmm developed by Temnij_Chudak \n Version 0.0.4";
        private ChromiumWebBrowser chrome;


        public Youtube()
        {
            InitializeComponent();



        }
        private void Youtube_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chrome = new ChromiumWebBrowser("http://youtube.com");
            pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private bool isDragging = false;
        private int currentX, currentY;

        private void gunaPanel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                currentX = e.X;
                currentY = e.Y;
            }
        }
        private void gunaPanel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isDragging)
            {
                Top = Top + (e.Y - currentY);
                Left = Left + (e.X - currentX);
            }
        }
        private void gunaPanel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }




        private void библиоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.youtube.com/feed/library");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YSettings set = new YSettings(lang);
            set.ShowDialog();
            lang = set.lang;
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
                MessageBox.Show(aboutrus, "О мне");
            }
            else
            {
                MessageBox.Show(abouteng, "About");
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("http://www.youtube.com");
        }

        private void вТрендеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.youtube.com/feed/trending");
        }

        private void подпискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.youtube.com/feed/subscriptions");
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.youtube.com/feed/history");
        }

        private void вашиВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chrome.Load("https://www.youtube.com/feed/my_videos");
        }


    }
}
