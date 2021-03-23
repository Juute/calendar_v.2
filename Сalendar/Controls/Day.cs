using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Сalendar;

namespace Calendar.Controls
{
    public struct _Object
    {
        public string month;
        public string time;
        public string title;
        public string note;
        public int day_number;
        public string day;
        public Color color;
    }
    
    public partial class Day : UserControl
    {
        public string NameDay { get { return label1.Text; } set { label1.Text = value; } }
        Color LightRed = Color.FromArgb(255, 140, 140);
        Color OverControl = Color.FromArgb(255, 183, 135);
        public _Object note;
        ToolTip toolTip = new ToolTip();

        public Day()
        {
            InitializeComponent();
        }
        private readonly Dictionary<int, string> months = new Dictionary<int, string> {{1,"Январь"},
            {2,"Февраль"},{3,"Март"},{4,"Апрель"},{5,"Май"},{6,"Июнь"},{7,"Июль"},
            { 8,"Август"},{9,"Сентябрь"},{10,"Октябрь"},{11,"Ноябрь"},{12,"Декабрь"} };
        private readonly Dictionary<string, string> days = new Dictionary<string, string>() { { "Monday", "Понедельник" },
            { "Tuesday","Вторник" },{ "Wednesday","Среда" },{ "Thursday","Четверг" },{ "Friday","Пятница" },
            { "Saturday","Суббота" },{ "Sunday","Воскресенье" }};

        public void Note(int Year, int Mouth, int i)
        {
            note = new _Object()
            {
                month = months[Mouth],
                title = "",
                note = "",
                day_number = i,
                day = days[new DateTime(Year, Mouth, i).DayOfWeek.ToString()],
                color = Color.White
            };

            string str = days[new DateTime(Year, Mouth, i).DayOfWeek.ToString()];
            if (str == "Суббота" || str == "Воскресенье")
            {
                SetColor(LightRed);
            }

            switch (months[Mouth])
            {
                case "Январь":
                    if (i >= 1 && i <= 8)
                    {
                        SetColor(LightRed);
                    }
                    break;
                case "Февраль":
                    if (i == 23) { SetColor(LightRed); }
                    break;
                case "Март":
                    if (i == 8) { SetColor(LightRed); }
                    break;
                case "Май":
                    if (i == 1) { SetColor(LightRed); }
                    if (i == 9) { SetColor(LightRed); }
                    break;
                case "Июнь":
                    if (i == 12) { SetColor(LightRed); }
                    break;
                case "Ноябрь":
                    if (i == 4) { SetColor(LightRed); }
                    break;
            }
        }

        public void SetColor(Color color)
        {
            BackColor = color;
        }

        public Color GetColor()
        {
            return this.BackColor;
        }

        private void Day_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
            {
                BackColor = OverControl;
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (BackColor == OverControl)
            {
                BackColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Note myNote = new Note(note);
            myNote.FormClosing += MyNote_FormClosing;
            myNote.Show();
        }

        private void MyNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Note myNote = (Note)sender;
            if (myNote.NoClickExit)
            {
                note.time = myNote.myTime;
                note.title = myNote.Title;
                note.note = myNote.myNote;
                note.color = myNote.NoteCalor;
                SetColor(note.color);
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (note.title.Trim() != "")
            {
                toolTip.SetToolTip((Label)sender, note.title);
            }
            else
            {
                toolTip.SetToolTip((Label)sender, null);
            }
        }
    }
}
