using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
            if (lang.Equals("rus")){
                gunaLabel1.Text = "Язык";
                YSettings.ActiveForm.Text = "Настройки";

            }
            else
            {
                gunaLabel1.Text = "Language";
                YSettings.ActiveForm.Text = "Settings";
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try{
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
            catch{
                MessageBox.Show("err");
            }
            this.Close();

        }
    }
}
