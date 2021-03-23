using System;
using System.Collections.Generic;
using System.Drawing;
using Calendar.Controls;
using System.Windows.Forms;

namespace Calendar
{
    class PatternMouth
    {
        private readonly string[] m = new string[] {"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};
        private readonly Dictionary<int, string> months = new Dictionary<int, string> {{1,"Январь"},
            {2,"Февраль"},{3,"Март"},{4,"Апрель"},{5,"Май"},{6,"Июнь"},{7,"Июль"},
            { 8,"Август"},{9,"Сентябрь"},{10,"Октябрь"},{11,"Ноябрь"},{12,"Декабрь"} };

        private string NameMonth = "";
        private List<Controls.Day> days = new List<Controls.Day>();
        
        public PatternMouth(int Start, int End, int Year, int Mouth)
        {
            NameMonth = months[Mouth];

            for (int i = Start; i <= End; i++)
            {
                Controls.Day day = new Controls.Day();
                day.Note(Year, Mouth, i);
                days.Add(day);
            }
        }

        public Month CreateVisualObject()
        {
            Month control = new Month();
            control.NameMouth = NameMonth;

            int Start = GetStartDay();
            int N = 0;
            for (int i = 0; i < control.TableMouth.RowCount; i++)
            {
                for (int j = Start; j < control.TableMouth.ColumnCount; j++)
                {
                    if (N > days.Count - 1)
                        break;
                    days[N].NameDay = (N+1).ToString();
                    control.TableMouth.Controls.Add(days[N], j, i);
                    N++;
                }
                Start = 0;
            }

            return control;
        }

        private int GetStartDay()
        {
            string[] dayN = new string[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            for (int i = 0; i < dayN.Length; i++)
            {
                if (dayN[i] == days[0].note.day)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
