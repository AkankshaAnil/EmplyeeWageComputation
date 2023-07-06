internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Employee Wage Computation!");

        int IS_FULL_TIME = 1;
        Random random = new Random();
        int empCheck = random.Next(0,2);
        Console.WriteLine(empCheck);
        if(empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee Is Present");
        }
        else
        {
            Console.WriteLine("Employee Is Absent");
        }
    }
}