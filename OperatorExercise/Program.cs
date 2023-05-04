namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create two integer variables called a and b
            //17/4 is 4 remainder 1
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var reminder = a % b;
            Console.WriteLine(" quotient of   17/4   is " + quotient + " and the reminder is " + reminder);
            Console.WriteLine("enter your radius");
            var userinput = Console.ReadLine();
            var  radius = double.Parse(userinput);
            Console.WriteLine(AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
