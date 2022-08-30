using POOConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Date
    {
        //Attribute
        private int _year;
        private int _month;
        private int _day;

        //Constructor
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = CheckDay(year, month, day);
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Invalid Month");
        }

        private int CheckDay(int year, int month, int day)
        {
            try
            {
                if (month == 2 && month <= 29 && IsLeapYear(year))
                {
                    return day;
                }

                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (day >= 1 && day <= daysPerMonth[month])
                {
                    return day;
                }

                throw new DayException("Invalid Day");
            }
            catch (Exception)
            {
                throw new DayException("Invalid Day");
            }
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        public override string ToString()
        {
            return $"{_year}/{CheckMonth(_month):00}/{_day:00}";
        }
    }
}
