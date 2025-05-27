namespace Practices.Exercises;

public class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        // For comparison purposes, you always keep a copy of last week's counts nearby, which were: 0, 2, 5, 3, 7, 8 and 4. Implement the (static) BirdCount.LastWeek() method that returns last week's counts:
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        // Implement the BirdCount.Today() method to return how many birds visited your garden today. The bird counts are ordered by day, with the first element being the count of the oldest day, and the last element being today's count.
        return birdsPerDay[birdsPerDay.Length - 1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        // Implement the BirdCount.IncrementTodaysCount() method to increment today's count:
        birdsPerDay[birdsPerDay.Length - 1]++;
        // throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        // Implement the BirdCount.HasDayWithoutBirds() method that returns true if there was a day at which zero birds visited the garden; otherwise, return false:
        foreach (int count in birdsPerDay)
        {
            if (count == 0)
                return true;
        }
        return false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // Implement the BirdCount.CountForFirstDays() method that returns the number of birds that have visited your garden from the start of the week, but limit the count to the specified number of days from the start of the week.
        int sum = 0;
        for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++)
        {
            sum += birdsPerDay[i];
        }
        return sum;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        // Some days are busier that others. A busy day is one where five or more birds have visited your garden. Implement the BirdCount.BusyDays() method to return the number of busy days:
        int count = 0;
        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
                count++;
        }
        return count;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}