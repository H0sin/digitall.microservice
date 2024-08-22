using System.Globalization;

namespace Application.Helper;

public static class PersianDateTimeHelper
{
    public static string GetPersianDate(DateTime? dateTime)
    { 
        if (dateTime is null)
            return "";
            
        PersianCalendar pc = new PersianCalendar();
        return $"{pc.GetYear(dateTime.Value)}/{pc.GetMonth(dateTime.Value):00}/{pc.GetDayOfMonth(dateTime.Value):00}";
    }
}