using Calendar;
using System;
using System.Windows.Forms;

namespace Сalendar
{
    public partial class CalendarOnYear : Form
    {
        public int year = 0, column = 0;
        public bool Exit = false;
        public CalendarOnYear()
        {
            InitializeComponent();
        }

        private void CalendarOnYear_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                year = int.Parse(textBoxYear.Text);
                column = int.Parse(comboBox1.Text);
                Exit = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Проверьте поля ввода!");
            }
        }
    }
}
