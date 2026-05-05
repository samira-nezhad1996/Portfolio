using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Convertor
{
    public static class DateConvertor
    {
        public static string? ToShamsi(this DateTime? date)
        {
            if (date == null) return null;
            PersianCalendar pc = new PersianCalendar();

            return $"{pc.GetYear(date.Value)}/{pc.GetMonth(date.Value)}/{pc.GetDayOfMonth(date.Value)}";

        }
    }
}

