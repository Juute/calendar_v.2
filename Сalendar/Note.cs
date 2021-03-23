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
    public partial class Note : Form
    {
        public string Title { get; set; }
        public string myNote { get; set; }
        public string myTime { get; set; }
        public Color NoteCalor { get; set; } = Color.FromArgb(124,200,255);
        public bool NoClickExit = false;

        public Note(Calendar.Controls._Object note)
        {
            InitializeComponent();

            textBox1.Text = note.title;
            textBox2.Text = note.note;
            labelMonth.Text = note.month;
            maskedTextBoxTime.Text = note.time;
            labelDay.Text = note.day+ " " + note.day_number;

            NoteCalor = note.color;
            Title = note.title;
            myNote = note.note;
            myTime = note.time;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                NoClickExit = true;
                Title = textBox1.Text;
                myNote = textBox2.Text;
                myTime = maskedTextBoxTime.Text;
                NoteCalor = NoteCalor == Color.White ? Color.FromArgb(124, 200, 255) : NoteCalor;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните заголовок!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NoteCalor = colorDialog1.Color != Color.White && colorDialog1.Color != Color.FromArgb(255, 86, 86) ? colorDialog1.Color : Color.FromArgb(124, 200, 255);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoClickExit = true;
            myTime = "";
            Title = "";
            myNote = "";
            NoteCalor = Color.White;
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
