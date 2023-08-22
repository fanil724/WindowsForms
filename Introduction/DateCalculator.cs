using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class DateCalculator : Form
    {
        public DateCalculator()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            if (startDate > endDate)
            {
                MessageBox.Show(this, "End date cannot be less then start date",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int years = 0, monthes = 0, days = 0;
            string result = "Результат вычисления даты: ";
            string units = comboBox1.SelectedItem.ToString();
            years = endDate.Year - startDate.Year;
            if (endDate.Month >= startDate.Month)
            {
                monthes = endDate.Month - startDate.Month;
            }
            else
            {
                years--;
                monthes = endDate.Month + 12 - startDate.Month;
            }
            if (endDate.Day > startDate.Day)
            {
                days = endDate.Day - startDate.Day;
            }
            else
            {
                monthes--;
                int daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
                days = daysInMonth - startDate.Day + endDate.Day;
            }
            switch (units)
            {
                default:
                case "Years":
                    {
                        result += years.ToString() + (years == 1 ? " year" : " years") + " " + monthes.ToString() + (monthes == 1 ? " month" : " months") +
                            " " + days.ToString() + (days == 1 ? " day" : " days");
                    }
                    break;
                case "Monthes":
                    {
                        if (years > 0) monthes += (12 * years);

                        result += monthes.ToString() + (monthes == 1 ? " month" : " months") +
                            " " + days.ToString() + (days == 1 ? " day" : " days");
                    }
                    break;
                case "Days":
                    {
                        if (years > 0) monthes += (12 * years);

                        int month = startDate.Month + 1;
                        int year = startDate.Year;
                        for (int i = monthes; i > 0; i--)
                        {
                            days += DateTime.DaysInMonth(year, month);
                            if (month == 12)
                            {
                                month = 1;
                                year++;
                            }
                            else
                            {
                                month++;
                            }
                        }
                        result += days.ToString() + (days == 1 ? " day" : " days");
                    }
                    break;
            }
            MessageBox.Show(this, result, "Interval");
        }
    }
}
