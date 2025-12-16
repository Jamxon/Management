using Management.Application.Services;

namespace Management.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siz 12ta o`quvchi qo`shaolasiz");
            int limit = 12;
            while (true)
            {
                
                Console.WriteLine("Enter Student First Name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Student Last Name:");
                string lastName = Console.ReadLine();
                
                for (int i = 0; i <= 12; i++)
                {
                    StudentService studentService = new StudentService();
                    studentService.AddStudents(firstName, lastName);
                }
                limit--;
                Console.WriteLine($"Sizning limitingiz {limit}ta");

                if (limit == 0)
                {
                    Console.WriteLine("Sizning limitingiz tugadi");
                    break;
                }
            }
        }
    }
}