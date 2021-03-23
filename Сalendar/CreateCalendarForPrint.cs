using Calendar.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CreateDocHtml
{
    class CreateCalendarForPrint
    {
        public void PrintCalendar(Calendar.Form1 form)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".html";
            saveFileDialog.Filter = "Document|*.html";          

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Month> months = form.months;

                StreamWriter streamwriter = new StreamWriter(saveFileDialog.FileName);
                streamwriter.WriteLine("<!DOCTYPE html>");
                streamwriter.WriteLine("<html lang=\"ru\">");
                streamwriter.WriteLine(" <head>");
                streamwriter.WriteLine("  <meta charset=\"UTF-8\">");
                streamwriter.WriteLine("  <meta name=\"viewport\" content=\"width = device-width, initial-scale = 1.0\">");
                streamwriter.WriteLine("  <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">");
                streamwriter.WriteLine("  <title>Календарь</title>");
                streamwriter.WriteLine(" </head>");
                streamwriter.WriteLine("<body style=\"font-family: Comic Sans MS\">");

                streamwriter.WriteLine(" <table style=\"margin: auto\">");
                streamwriter.WriteLine(" <caption style=\"margin-bottom: 30px; \">" + form.label1.Text + "</caption>");
                streamwriter.WriteLine(" <tr>");
                streamwriter.WriteLine("  <td>");

                string day = ""; int row = 1; bool newRow = false;
                for (int i = 0; i < months.Count; i++)
                {
                    Month month = months[i];
                    TableLayoutPanel table = month.TableMouth;

                    if (row % (int)month.Tag == 0)
                    {
                        newRow = true;
                    }

                    streamwriter.WriteLine("   <table style=\"display: inline-block; vertical-align: top; margin-right: 15px;\"> ");
                    streamwriter.WriteLine("   <caption>" + month.NameMouth + "</caption>");

                    for (int j = 0; j < table.RowCount; j++)
                    {
                        streamwriter.WriteLine("   <tr>");

                        for (int b = 0; b < table.ColumnCount; b++)
                        {
                            Calendar.Controls.Day control = (Calendar.Controls.Day)table.GetControlFromPosition(b, j);

                            if (control != null)
                            {
                                Color currColor = control.BackColor;
                                day = control.Controls[0].Text;

                                streamwriter.WriteLine("    <td style=\"background-color:RGB(" + currColor.R + ", " + currColor.G + ", " + currColor.B + "); " +
                                    "width: 25px; height: 25px; text-align: center\">" + day + "</td>");
                            }
                            else
                            {
                                streamwriter.WriteLine("    <td style=\"background-color:RGB(255,255,255); " +
                                    "width: 25px; height: 25px; text-align: center\"></td>");
                            }
                        }
                        streamwriter.WriteLine("   </tr>");
                    }

                    streamwriter.WriteLine("  </table>");

                    if (newRow)
                    {
                        streamwriter.WriteLine("   <div style=\"display: block; height: 5px;\"></div>");
                        newRow = false;
                    }

                    row++;
                }

                streamwriter.WriteLine("  </td>");
                streamwriter.WriteLine(" </tr>");
                streamwriter.WriteLine(" </table>");

                streamwriter.WriteLine("</body>");
                streamwriter.WriteLine("</html>");
                streamwriter.Close();
            }
        }

        public void PrintCalendarOnDay(Calendar.Form1 form)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".html";
            saveFileDialog.Filter = "Document|*.html";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Сalendar.Controls.OnDay onDay = (Сalendar.Controls.OnDay)form.onDay;

                StreamWriter streamwriter = new StreamWriter(saveFileDialog.FileName);
                streamwriter.WriteLine("<!DOCTYPE html>");
                streamwriter.WriteLine("<html lang=\"ru\">");
                streamwriter.WriteLine(" <head>");
                streamwriter.WriteLine("  <meta charset=\"UTF-8\">");
                streamwriter.WriteLine("  <meta name=\"viewport\" content=\"width = device-width, initial-scale = 1.0\">");
                streamwriter.WriteLine("  <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">");
                streamwriter.WriteLine("  <title>Заметки</title>");
                streamwriter.WriteLine(" </head>");
                streamwriter.WriteLine("<body style=\"font-family: Comic Sans MS\">");

                streamwriter.WriteLine("  <div style=\"width: 700px; margin: auto\">");
                streamwriter.WriteLine("    <div style=\"text-align: center\">" + form.label1.Text + "</div>");
                streamwriter.WriteLine("    <div style=\"display: flex; justify-content: space-between; margin-bottom: 15px; margin-top: 30px; padding-top: 10px; border-top: 5px solid RGB(" + onDay.marker.BackColor.R + "," + onDay.marker.BackColor.G + "," + onDay.marker.BackColor.B + "); font-weight: bold; font-size: 16px\">");
                streamwriter.WriteLine("      <div style=\"text-align: left; width: 30%; padding-left: 3px;\">" + onDay.lbldate.Text + "</div>");
                streamwriter.WriteLine("      <div style=\"text-align: center;\">" + onDay.lblday.Text + "</div>");
                streamwriter.WriteLine("      <div style=\"text-align: right; width: 30%; padding-right: 3px;\">" + onDay.mtextbox.Text + "</div>");
                streamwriter.WriteLine("    </div>");
                streamwriter.WriteLine("    <div style=\"display: block; text-align: left; width: 100%; margin-top: 30px; margin: 3px 0px 0px 3px\">Заметка:</div>");
                streamwriter.WriteLine("    <div style=\"display: block; text-align: left; width: 100%; margin-top: 10px; margin: 5px 0px 0px 5px\">" + onDay.note.Text + "</div>");
                streamwriter.WriteLine("  </div>");

                streamwriter.WriteLine("</body>");
                streamwriter.WriteLine("</html>");
                streamwriter.Close();
            }
        }

        public void PrintNotes(Calendar.Form1 form)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".html";
            saveFileDialog.Filter = "Document|*.html";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Month> months = form.months;

                StreamWriter streamwriter = new StreamWriter(saveFileDialog.FileName);
                streamwriter.WriteLine("<!DOCTYPE html>");
                streamwriter.WriteLine("<html lang=\"ru\">");
                streamwriter.WriteLine(" <head>");
                streamwriter.WriteLine("  <meta charset=\"UTF-8\">");
                streamwriter.WriteLine("  <meta name=\"viewport\" content=\"width = device-width, initial-scale = 1.0\">");
                streamwriter.WriteLine("  <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">");
                streamwriter.WriteLine("  <title>Заметки</title>");
                streamwriter.WriteLine(" </head>");
                streamwriter.WriteLine("<body style=\"font-family: Comic Sans MS\">");

                streamwriter.WriteLine("<div style=\"width: 100%; text-align: center;\">Заметки на " + form.year + " год</div>");
                for (int i = 0; i < months.Count; i++)
                {
                    Month month = months[i];
                    TableLayoutPanel table = month.TableMouth;

                    for (int j = 0; j < table.RowCount; j++)
                    {

                        for (int b = 0; b < table.ColumnCount; b++)
                        {
                            Calendar.Controls.Day control = (Calendar.Controls.Day)table.GetControlFromPosition(b, j);

                            if (control != null && control.note.title.Trim() != "")
                            {
                                streamwriter.WriteLine("  <div style=\"width: 700px; margin: auto; margin-button: 20px\">");
                                streamwriter.WriteLine("    <div style=\"display: flex; justify-content: space-between; margin-bottom: 15px; margin-top: 30px; padding-top: 10px; border-top: 5px solid RGB(" + control.note.color.R + ", " + control.note.color.G + ", " + control.note.color.B + "); font-weight: bold; font-size: 16px\">");
                                streamwriter.WriteLine("      <div style=\"text-align: left; width: 30%; padding-left: 3px;\">" + control.note.month + "</div>");
                                streamwriter.WriteLine("      <div style=\"text-align: center;\">" + control.note.day + " " + control.note.day_number + "</div>");
                                streamwriter.WriteLine("      <div style=\"text-align: right; width: 30%; padding-right: 3px;\">" + control.note.time + "</div>");
                                streamwriter.WriteLine("    </div>");
                                streamwriter.WriteLine("    <div style=\"display: block; text-align: left; width: 100%; margin-top: 30px; margin: 3px 0px 0px 3px\">Заметка: "+control.note.title+"</div>");
                                streamwriter.WriteLine("    <div style=\"display: block; text-align: left; width: 100%; margin-top: 10px; margin: 5px 0px 0px 5px\">" + control.note.note + "</div>");
                                streamwriter.WriteLine("  </div>");
                            }
                            else
                            {
                                streamwriter.WriteLine("");
                            }
                        }
                    }
                }

                streamwriter.WriteLine("</body>");
                streamwriter.WriteLine("</html>");
                streamwriter.Close();
            }
        }
    }
}
