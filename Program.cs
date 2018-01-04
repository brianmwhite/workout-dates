using System;

namespace workout_dates
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out var year))
            {
                year = DateTime.Now.Year;
            }

            var startDate = new DateTime(year,1,1);
            var endDate = new DateTime(year,12,31);

            for (var i = startDate; i<=endDate; i = i.AddDays(1))
            {
                switch (i.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Thursday:
                        Console.WriteLine(i.ToString("MM/dd/yyyy"));
                        break;
                }
            }
       }
    }
}
