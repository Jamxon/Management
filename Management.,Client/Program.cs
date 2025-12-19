using Management.Application.Services;
using Management.Domain.Models;

namespace Management.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TeacherService teacherService = new TeacherService();
            StudentService studentService = new StudentService();
            Console.WriteLine("Assalomu Aleykum bizming Student MAnagament loyihamizga xush kelibsiz");
            Console.WriteLine("Bizda quyidagi imkoniyatlar mavjud:");
            while (true)
            {

                Console.WriteLine("1)Ro`yhatdan o`tish");
                Console.WriteLine("2)O`quvchi qo`shish");
                Console.WriteLine("3)O`quvchilar Ro`yhati bilan tanishish");
                Console.WriteLine("4)Chiqish");
                Console.WriteLine("Qaysi birini tanlaysiz:");
                int menuNumber = Convert.ToInt32(Console.ReadLine());
                if (menuNumber == 1)
                {
                    Console.WriteLine("O`qituvchimisiz(1) yoki O`quvchi(2)");
                    int roleNumber = Convert.ToInt32(Console.ReadLine());
                    if (roleNumber == 1)
                    {
                        Console.WriteLine("Xurmatli o`qutivchi ismingizni kiriting:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Familiyangizni kiriting:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Parolingizni kiriting");
                        int password = Convert.ToInt32(Console.ReadLine());

                        teacherService.AddTeacher(firstName, lastName, password);
                        Console.WriteLine("Muvafaqiyatli ro`yhatdan o`tdiz");
                        continue;
                    }
                    else if (roleNumber == 2)
                    {
                        Console.WriteLine("Sizni faqat O`qituvchilarimiz ro`yhatga olaoladi");
                        return;
                    }
                }
                else if (menuNumber == 2)
                {
                    int passwordAttempt = 3;
                    int password;
                    while (passwordAttempt > 0)
                    {
                        Console.WriteLine("Parolni Kiriting");
                        password = Convert.ToInt32(Console.ReadLine());
                        var teacher = teacherService.GetTeacher();
                        if (teacher == null || teacher.Password != password)
                        {
                            passwordAttempt--;
                            if (passwordAttempt != 0)
                            {
                                Console.WriteLine("Parol xato qayta urinib ko`ring");
                                Console.WriteLine($"Sizda yana {passwordAttempt} urinish bor ");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Sizda urinishlar tugadi");
                                break;
                            }
                        }

                        Console.WriteLine("Parol to`g`ri");
                        Console.WriteLine("Siz 12ta o`quvchi qo`shaolasiz");
                        int limit = 12;
                        while (limit > 0)
                        {
                            Console.WriteLine("Enter Student First Name:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter Student Last Name:");
                            string lastName = Console.ReadLine();
                            studentService.AddStudents(firstName, lastName);
                            limit--;
                            Console.WriteLine($"Sizning limitingiz {limit}ta");
                            if (limit == 0)
                            {
                                Console.WriteLine("Barcha o`quvchilar muvafaqiyatli qo`shildi!");
                                Console.WriteLine("Sizning limitingiz tugadi");
                                break;
                            }
                        }
                        Student[] student = studentService.GetStudents();
                        int studentCount = Convert.ToInt32(student.Length.ToString());
                        if (studentCount > 0) { break; }
                    }
                }
                else if (menuNumber == 3)
                {
                    var students = studentService.GetStudents();
                    Console.WriteLine("O`quvchilar Ro`yhati:");
                    foreach (var student in students)
                    {
                        if (student != null)
                        {
                            Console.WriteLine($"ID:{student.Id} | Ism: {student.FirstName} | Familiyasi: {student.LastName}");
                        }
                    }
                }
                else if (menuNumber == 4)
                {
                    Console.WriteLine("Dasturdan chiqilyapti...");
                    break;

                }
            }
        }
    }
}