namespace ID;

public class Formatter
{
    public static DateTime idNumberToDate(String idNumber)
    {
        int yearTwoDigit = int.Parse(idNumber.Substring(0, 2));
        int year         = Formatter.fullYear(yearTwoDigit);
        int month        = int.Parse(idNumber.Substring(2, 2));
        int day          = int.Parse(idNumber.Substring(4, 2));
        return new DateTime(year, month, day);
    }

    public static int fullYear(int year)
    {
        return System.Globalization.CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(year);
    }
}