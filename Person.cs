namespace IT_1050_Lab_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;
                
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

            public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);





        }


    }
    

      


    }

