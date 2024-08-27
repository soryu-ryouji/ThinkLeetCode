namespace ThinkLeetCode.Problem_01608;

public class Program
{
    public static void Main(string[] args)
    {
        if (Test()) Console.WriteLine("Pass");
        else Console.WriteLine("Fail");
    }

    public static bool Test()
    {
        if (SpecialArray([3, 5]) != 2) return false;
        if (SpecialArray([0, 0]) != 2) return false;
        if (SpecialArray([0, 4, 3, 0, 4]) != 3) return false;
        if (SpecialArray([3, 6, 7, 7, 0]) != 3) return false;

        return true;
    }

    public static int SpecialArray(int[] nums)
    {
        throw new NotImplementedException();
    }
}