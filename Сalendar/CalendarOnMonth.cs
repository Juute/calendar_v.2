using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сalendar
{
    public partial class CalendarOnMonth : Form
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public bool Exit = false;

        public CalendarOnMonth()
        {
            InitializeComponent();
        }

        private void CalendarOnMonth_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                try
                {
                    Year = int.Parse(textBoxYear.Text);
                    Month = comboBox1.Text;
                    Exit = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
