using System;
using System.Collections.Generic;
using Calendar.Controls;
using System.Windows.Forms;
using Сalendar;
using CreateDocHtml;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public List<Month> months = new List<Month>();
        private int mode = 0;
        public Сalendar.Controls.OnDay onDay;
        public int year = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void наГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarOnYear onYear = new CalendarOnYear();
            onYear.FormClosing += OnYear_FormClosing;
            onYear.ShowDialog();
        }

        private void OnYear_FormClosing(object sender, FormClosingEventArgs e)
        {
            CalendarOnYear onYear = (CalendarOnYear)sender;

            if (onYear.Exit)
            {
                year = onYear.year;
                int column = onYear.column;
                
                if (year > 1600)
                {
                    mode = 0;

                    months.Clear();
                    label1.Text = "Календарь на " + year + " год";
                    flowLayoutPanel1.Controls.Clear();
                    PatternCalendar calendar = new PatternCalendar();
                    months = calendar.GetMouths(year, new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
                    int count = 0;
                    foreach (Month item in months)
                    {
                        if (count < column - 1)
                        {
                            item.Tag = column;
                            flowLayoutPanel1.Controls.Add(item);
                            flowLayoutPanel1.SetFlowBreak(item, false);
                            count++;
                        }
                        else
                        {
                            item.Tag = column;
                            flowLayoutPanel1.Controls.Add(item);
                            flowLayoutPanel1.SetFlowBreak(item, true);
                            count = 0;
                        }
                    }
                }
            }
        }

        private void наМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarOnMonth onMonth = new CalendarOnMonth();
            onMonth.FormClosing += OnMonth_FormClosing; ;
            onMonth.ShowDialog();
        }

        private void OnMonth_FormClosing(object sender, FormClosingEventArgs e)
        {
            CalendarOnMonth OnMonth = (CalendarOnMonth)sender;

            if (OnMonth.Exit)
            {
                if (year > 1700)
                {
                    mode = 0;
                    months.Clear();
                    year = OnMonth.Year;
                    string month = OnMonth.Month;
                    label1.Text = "Календарь на " + month + ", " + year + " год";

                    flowLayoutPanel1.Controls.Clear();
                    PatternCalendar calendar = new PatternCalendar();
                    months = calendar.GetMouths(year, new string[] { month });
                    months[0].Tag = 1;
                    flowLayoutPanel1.Controls.Add(months[0]);
                }
            }
        }

        private void наДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarOnDay Day = new CalendarOnDay();
            Day.FormClosing += OnDay_FormClosing; ;
            Day.ShowDialog();
        }

        private void OnDay_FormClosing(object sender, FormClosingEventArgs e)
        {
            CalendarOnDay Day = (CalendarOnDay)sender;
            if (Day.Exit)
            {
                mode = 1;
                flowLayoutPanel1.Controls.Clear();
                months.Clear();
                onDay = new Сalendar.Controls.OnDay();

                year = Day._Data.year;
                label1.Text = "Календарь на " + Day._Data.dayNumber + " " + Day._Data.month + " " + Day._Data.year + " год";

                onDay.lbldate.Text = Day._Data.dayNumber + " " + Day._Data.month + " " + Day._Data.year + " год";
                onDay.lblday.Text = Day._Data.day;
                onDay.mtextbox.Text = Day._Data.h.ToString() + ":" + Day._Data.m;
                flowLayoutPanel1.Controls.Add(onDay);
            }
        }

        private void календарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCalendarForPrint forPrint = new CreateCalendarForPrint();
            if (mode == 0 && months.Count != 0)
            {
                forPrint.PrintCalendar(this);
            }
            else
            {
                forPrint.PrintCalendarOnDay(this);
            }
        }

        private void заметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCalendarForPrint forPrint = new CreateCalendarForPrint();
            if (mode == 0 && months.Count != 0)
            {
                forPrint.PrintNotes(this);
            }
        }
    }
}
