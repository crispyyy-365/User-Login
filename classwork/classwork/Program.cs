namespace classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[0];

            int option = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (option)
                {
                    case 1:

                        Employee emp = new();

                        emp.Name = Console.ReadLine();

                        Array.Resize(ref employees, employees.Length + 1);

                        employees[employees.Length - 1] = emp;

                        break;

                }
            }
            while (option > 0 && option <= 6);
        }
    }

}