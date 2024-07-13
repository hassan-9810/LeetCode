public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        
        DateTime dt1 = DateTime.Parse(date1);
        DateTime dt2 = DateTime.Parse(date2);
        
        TimeSpan ts = dt2 - dt1;
        
        return (int)Math.Abs(ts.TotalDays);
    }
}