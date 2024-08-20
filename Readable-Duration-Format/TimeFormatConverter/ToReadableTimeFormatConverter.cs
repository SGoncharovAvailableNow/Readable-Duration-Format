using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readable_Duration_Format.TimeFormatConverter
{
    internal class ToReadableTimeFormatConverter
    {
        private enum TimesInSeconds : int
        {
            Day = 86400,
            Hour = 3600,
            Minute = 60
        }
        public string TimeFormatConverter(int innerSeconds)
        {
            if (innerSeconds == 0)
            {
                return "Now";
            }

            return innerSeconds > (int)TimesInSeconds.Day ? MoreOneDayFromSeconds(innerSeconds) :
                (innerSeconds < (int)TimesInSeconds.Day && innerSeconds > (int)TimesInSeconds.Hour) ? MoreOneHourFromSeconds(innerSeconds) :
                (innerSeconds < (int)TimesInSeconds.Hour && innerSeconds > (int)TimesInSeconds.Minute) ? MoreOneMinuteFromSeconds(innerSeconds) :
                LessOneMinuteFromSeconds(innerSeconds);
        }

        public string TimeFormatConverterII(int innerSeconds)
        {
            if (innerSeconds == 0)
            {
                return "Now";
            }

            return ReturningStringContructocr(innerSeconds);
        }

        private string ReturningStringContructocr(int seconds)
        {
            string daysBlock = "";
            string hoursBlock = "";
            string minutesBlock = "";
            string secondsBlock = "";

            switch (TimeSpan.FromSeconds(seconds).Days)
            {
                case 0: daysBlock = ""; break;
                case 1: daysBlock = $"{TimeSpan.FromSeconds(seconds).Days} день "; break;
                case 2: daysBlock = $"{TimeSpan.FromSeconds(seconds).Days} дня "; break;
                case 3: daysBlock = $"{TimeSpan.FromSeconds(seconds).Days} дня "; break;
                case 4: daysBlock = $"{TimeSpan.FromSeconds(seconds).Days} дня "; break;
                default: daysBlock = $"{TimeSpan.FromSeconds(seconds).Days} дней "; break;
            }

            switch (TimeSpan.FromSeconds(seconds).Hours)
            {
                case 0: hoursBlock = ""; break;
                case 1: hoursBlock = $"{TimeSpan.FromSeconds(seconds).Hours} час "; break;
                case 2: hoursBlock = $"{TimeSpan.FromSeconds(seconds).Hours} часа "; break;
                case 3: hoursBlock = $"{TimeSpan.FromSeconds(seconds).Hours} часа "; break;
                case 4: hoursBlock = $"{TimeSpan.FromSeconds(seconds).Hours} часа "; break;
                default: hoursBlock = $"{TimeSpan.FromSeconds(seconds).Hours} часов "; break;
            }

            switch (TimeSpan.FromSeconds(seconds).Minutes)
            {
                case 0: minutesBlock = ""; break;
                case 1: minutesBlock = $"{TimeSpan.FromSeconds(seconds).Minutes} минута "; break;
                case 2: minutesBlock = $"{TimeSpan.FromSeconds(seconds).Minutes} минуты "; break;
                case 3: minutesBlock = $"{TimeSpan.FromSeconds(seconds).Minutes} минуты "; break;
                case 4: minutesBlock = $"{TimeSpan.FromSeconds(seconds).Minutes} минуты "; break;
                default: minutesBlock = $"{TimeSpan.FromSeconds(seconds).Minutes} минут "; break;
            }

            if (TimeSpan.FromSeconds(seconds).Days == 0 && TimeSpan.FromSeconds(seconds).Hours == 0 && TimeSpan.FromSeconds(seconds).Minutes == 0)
            {
                switch (TimeSpan.FromSeconds(seconds).Seconds)
                {
                    case 0: secondsBlock = ""; break;
                    case 1: secondsBlock = $"{TimeSpan.FromSeconds(seconds).Seconds} секунда."; break;
                    case 2: secondsBlock = $"{TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    case 3: secondsBlock = $"{TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    case 4: secondsBlock = $"{TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    default: secondsBlock = $"{TimeSpan.FromSeconds(seconds).Seconds} секунд."; break;
                }
            }
            else
            {
                switch (TimeSpan.FromSeconds(seconds).Seconds)
                {
                    case 0: secondsBlock = ""; break;
                    case 1: secondsBlock = $"и {TimeSpan.FromSeconds(seconds).Seconds} секунда."; break;
                    case 2: secondsBlock = $"и {TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    case 3: secondsBlock = $"и {TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    case 4: secondsBlock = $"и {TimeSpan.FromSeconds(seconds).Seconds} секунды."; break;
                    default: secondsBlock = $"и {TimeSpan.FromSeconds(seconds).Seconds} секунд."; break;
                }
            }

            return $"{daysBlock}{hoursBlock}{minutesBlock}{secondsBlock}";
        }

        private string MoreOneDayFromSeconds(int seconds)
        {
            return $"{TimeSpan.FromSeconds(seconds).Days} days {TimeSpan.FromSeconds(seconds).Hours} hours {TimeSpan.FromSeconds(seconds).Minutes} minutes and {TimeSpan.FromSeconds(seconds).Seconds} seconds.";
        }

        private string MoreOneHourFromSeconds(int seconds)
        {
            return $"{TimeSpan.FromSeconds(seconds).Hours} hours {TimeSpan.FromSeconds(seconds).Minutes} minutes and {TimeSpan.FromSeconds(seconds).Seconds} seconds.";
        }

        private string MoreOneMinuteFromSeconds(int seconds)
        {
            return $"{TimeSpan.FromSeconds(seconds).Minutes} minutes and {TimeSpan.FromSeconds(seconds).Seconds} seconds.";
        }

        private string LessOneMinuteFromSeconds(int seconds)
        {
            return $"{TimeSpan.FromSeconds(seconds).Seconds} seconds.";
        }
    }
}
