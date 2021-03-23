using System;
using System.Windows.Forms;

namespace Сalendar.Controls
{
    public partial class OnDay : UserControl
    {
        public Label lbldate;
        public Label lblday;
        public MaskedTextBox mtextbox;
        public PictureBox marker;
        public TextBox note;

        public OnDay()
        {
            InitializeComponent();

            lbldate = label_date;
            lblday = label_day;
            mtextbox = maskedTextBox1;
            marker = pictureBox1;
            note = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                marker.BackColor = colorDialog1.Color;
            }
        }
    }
}
