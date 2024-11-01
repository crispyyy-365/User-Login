using System.Runtime.CompilerServices;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseService service = new CourseService();

            int opiton;

            do
            {
                Console.WriteLine("1.Create a new group\n2.Show all the groups\n3.Edit gorup\n4.Show the students int the group\n5.Show all the students\n6.Create a student\n7.Remove Group\n8.Remove Student\n\n0.Exit\n\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        int number;
                        do
                        {
                            Console.WriteLine("Enter the number : ");

                            number = Convert.ToInt32(Console.ReadLine());

                            if (number >= 100 || number <= 999)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("The number should be a positive 3 digit number !");
                            }
                        }
                        while (true);

                        int answer;
                        bool isOnLine;

                        do
                        {
                            Console.WriteLine("Is the group online ? \n\n1.Yes\n2.No\n0.Back\n\n");

                            answer = Convert.ToInt32(Console.ReadLine());

                            switch (answer)
                            {
                                case 1: 
                                    isOnLine = true; 
                                    break;
                                case 2: 
                                    isOnLine = false; 
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("The answer should be either yes or no !");
                                    break;
                            }
                        }
                        while (answer != 0) ;

                        int categoryInt;
                        Category category;

                        do
                        {
                            Console.WriteLine("Enter the category : \n\n1.Programming\n2.Design\n3.System Adminstration\n\n0.Back\n\n");

                            categoryInt = Convert.ToInt32(Console.ReadLine());

                            switch (categoryInt)
                            {
                                case (int)Category.Programming:
                                    category = Category.Programming;
                                    break;
                                case (int)Category.Design: 
                                    category = Category.Design;
                                    break;
                                case (int)Category.SystemAdminstration:
                                    category = Category.SystemAdminstration;
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("There is no such category !");
                                    break;
                            }
                        }
                        while(categoryInt != 0);

                        

                        
                    //case 2:

                        //    Console.WriteLine("These are all the gorups in the course :");

                        //    CourseService.ShowAllGroups();
                        //    break;

                        //case "6":

                        //    Console.WriteLine("Enter the student's name : ");

                        //    string name = CourseService.Capitalise(Console.ReadLine().Trim());

                        //    Console.WriteLine("Enter the student's Surname : ");

                        //    string Surname = CourseService.Capitalise(Console.ReadLine().Trim());

                        //    int groupNo = Convert.ToInt32(Console.ReadLine());



                }
            }
            while (option != 0);
        }
    }
}