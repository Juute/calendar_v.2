using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calendar.Controls;

namespace Calendar
{
    class PatternCalendar
    {
        private readonly string[] m = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        private List<Month> list_Months = new List<Month>();

        public List<Month> GetMouths(int Year, string[] Months)
        {
            for (int i = 0; i < Months.Length; i++)
            {
                Month mouth = null;
                if (Months[i] == "Февраль")
                {
                    if (Year % 4 != 0)
                    {
                        mouth = new PatternMouth(1, 28, Year, 2).CreateVisualObject();
                    }
                    else
                    {
                        mouth = new PatternMouth(1, 29, Year, 2).CreateVisualObject();
                    }
                }
                else
                {
                    int n = GetIndexMonth(Months[i]) + 1;
                    if(n <= 7)
                    {
                        if (n % 2 != 0)
                        {
                            mouth = new PatternMouth(1, 31, Year, n).CreateVisualObject();
                        }
                        else
                        {
                            mouth = new PatternMouth(1, 30, Year, n).CreateVisualObject();
                        }
                    }
                    else
                    {
                        if (n % 2 != 0)
                        {
                            mouth = new PatternMouth(1, 30, Year, n).CreateVisualObject();
                        }
                        else
                        {
                            mouth = new PatternMouth(1, 31, Year, n).CreateVisualObject();
                        }
                    }
                    
                }

                list_Months.Add(mouth);
            }

            return list_Months;
        }

        private int GetIndexMonth(string month)
        {
            for (int i = 0; i < m.Length; i++)
            {
                if (month == m[i])
                {
                    return i;
                }
            }
            return 0;
        }

        public void GetDay()
        {

        }
    }
}
