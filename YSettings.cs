using System;
using System.Windows.Forms;

namespace Youtube0._2
{
    public partial class YSettings : Form
    {
        public string lang = "eng";
        public YSettings(string lang)
        {
            InitializeComponent();
            lang = this.lang;
            if (this.lang.Equals("rus"))
            {
                gunaLabel1.Text = "Язык";
                YSettings.ActiveForm.Text = "Настройки";

            }
            else
            {
                gunaLabel1.Text = "Language";
                YSettings.ActiveForm.Text = "Settings";
            }

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



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaComboBox1.SelectedItem.Equals("Russian"))
                {
                    lang = "rus";
                    gunaLabel1.Text = "Язык";
                    YSettings.ActiveForm.Text = "Настройки";
                }
                else
                {
                    lang = "eng";
                    gunaLabel1.Text = "Language";
                    YSettings.ActiveForm.Text = "Settings";
                }
            }
            catch
            {
                MessageBox.Show("err");
            }
            Close();

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
