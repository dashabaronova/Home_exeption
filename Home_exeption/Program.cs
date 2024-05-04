namespace Home_exeption
{

    class Workler
    {
        
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string  Surname { get; set; }
        private DateTime hiredate;

        public DateTime Hiredate
        {
            get { return hiredate; }
            set {
                if (value >= DateTime.Now)
                { hiredate= value; }
                else { throw new Exception("Incorect day "); }
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { if (value>18)
                {
                    age = value;
                }
                else { throw new Exception(" Incorect age"); 
                }
            }
        }
        private int wage;

        public int Wage
        {
            get { return wage; }
            set
            {
                if (value > 1800)
                {
                    wage = value;
                }
                else
                {
                    throw new Exception(" Incorect wage");
                }
            }
        }


    public void Print()
        {
            Console.WriteLine(age);
            Console.WriteLine(Surname);
            Console.WriteLine(Firstname);
            Console.WriteLine(Lastname);
            Console.WriteLine(wage);

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Workler[] worker = new Workler[1];
            for (int i = 0; i < worker.Length; i++)
            {
                worker[i] = new Workler();
                try
                {
                    Console.WriteLine("Enter age");
                    worker[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter surname");
                    worker[i].Surname = Console.ReadLine();
                    Console.WriteLine("Enter firstname");
                    worker[i].Firstname = Console.ReadLine();
                    Console.WriteLine("Enter lastname");
                    worker[i].Lastname = Console.ReadLine();
                    Console.WriteLine("Enter Data");
                    worker[i].Hiredate = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            for (int i = 0; i < worker.Length; i++)
            {
                worker[i].Print();
            }

        }
    }
}