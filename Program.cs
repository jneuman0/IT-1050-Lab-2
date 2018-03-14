namespace IT_1050_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            System.Console.Write("What is your first name?");
            p1.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name?");
            p1.LastName = System.Console.ReadLine();
            System.Console.Write("How old are you?");
            p1.Age = int.Parse (System.Console.ReadLine());
            p1.Spouse = new Person();
            System.Console.Write("What is the name of your spouse?");
            p1.Spouse.FirstName = System.Console.ReadLine();
            p1.Spouse.LastName = p1.LastName;
            System.Console.Write("How old is your spouse?");
            p1.Spouse.Age = int.Parse(System.Console.ReadLine());
            p1.Spouse.Spouse = p1;
            Person.SumOfAllAges += p1.Age;
            Person.SumOfAllAges += p1.Spouse.Age;

            Person p2 = new Person();
            System.Console.Write("What is your first name?");
            p2.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name?");
            p2.LastName = System.Console.ReadLine();
            System.Console.Write("How old are you?");
            p2.Age = int.Parse(System.Console.ReadLine());
            p2.Spouse = new Person();
            System.Console.Write("What is the name of your spouse?");
            p2.Spouse.FirstName = System.Console.ReadLine();
            p2.Spouse.LastName = p2.LastName;
            System.Console.Write("How old is your spouse?");
            p2.Spouse.Age = int.Parse(System.Console.ReadLine());
            p2.Spouse.Spouse = p2;
            Person.SumOfAllAges += p2.Age;
            Person.SumOfAllAges += p2.Spouse.Age;

            p1.PrintNameAndAge();

            p1.Spouse.PrintNameAndAge();

            p2.PrintNameAndAge();

            p2.Spouse.PrintNameAndAge();

            System.Console.WriteLine(Person.SumOfAllAges / 4);



        

           


            
        

       


        }
    }
}
