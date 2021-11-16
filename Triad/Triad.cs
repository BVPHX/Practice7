using System;

namespace Triad
{
    public class Triads
    {
        protected int _first;
        protected int _second;
        protected int _third;

        public Triads()
        {
            Random rnd = new Random();
            _first = rnd.Next(0, 10);
            _second = rnd.Next(0, 10);
            _third = rnd.Next(0, 10);
        }

        public int First { get { return _first; } set { _first = value; } }
        public int Second { get { return _second; } set { _second = value; } }
        public int Third { get { return _third; } set { _third = value; } }

        public static bool operator >(Triads firstTriad, Triads secondTriad)
        {
            if (firstTriad.First > secondTriad.First && firstTriad.Second > secondTriad.Second && firstTriad.Third > secondTriad.Third) return true;
            else return false;
        }
        public static bool operator <(Triads firstTriad, Triads secondTriad)
        {
            if (firstTriad.First < secondTriad.First && firstTriad.Second < secondTriad.Second && firstTriad.Third < secondTriad.Third) return true;
            else return false;
        }

        public void IncreaseTriadValuesTo10()
        {
            _first += 10;
            _second += 10;
            _third += 10;
        }
    }
    public class Date : Triads
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year) : base()
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public static bool DateCompare(Date date1, Date date2)
        {
            if (date1.Year == date2.Year)
            {
                if (date1.Month >= date2.Month)
                {
                    if (date1.Day > date2.Day) return true;
                }
            }
            else return false;
            if (date1.Year > date2.Year) return true;
            if (date1.Year < date2.Year) return false;
            else return false;

        }
    }

}
