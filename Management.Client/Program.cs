using System;
using Management.Application.Services;

namespace Management.Client
{
    class Program
    {
        static StudentService studentService = new StudentService();
        static TeacherService teacherService = new TeacherService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DrawHeader("MAKTAB BOSHQARUV TIZIMI");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Kirish (Login)");
                Console.WriteLine("2. Ro'yxatdan o'tish (Register Teacher)");
                Console.WriteLine("0. Chiqish");
                Console.ResetColor();
                Console.Write("\nTanlang: ");

                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                    Login();
                else if (choice == "2")
                    RegisterTeacher();
                else if (choice == "0")
                    break;
            }
        }

        static void RegisterTeacher()
        {
            Console.Clear();
            DrawHeader("O'QITUVCHINI RO'YXATGA OLISH");

            Console.Write("Ism: ");
            string firstName = Console.ReadLine() ?? "";
            Console.Write("Familiya: ");
            string lastName = Console.ReadLine() ?? "";
            Console.Write("Username: ");
            string userName = Console.ReadLine() ?? "";
            Console.Write("Parol: ");
            string password = Console.ReadLine() ?? "";

            teacherService.AddTeacher(firstName, lastName, userName, password);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[!] Muvaffaqiyatli ro'yxatdan o'tdingiz!");
            Console.ResetColor();
            Thread.Sleep(1500);
        }

        static void Login()
        {
            Console.Clear();
            DrawHeader("TIZIMGA KIRISH");

            Console.Write("Username: ");
            string username = Console.ReadLine() ?? "";
            Console.Write("Password: ");
            string password = Console.ReadLine() ?? "";

            var teacher = teacherService
                .GetTeachers()
                .FirstOrDefault(t => t.Username == username && t.Password == password);

            if (teacher != null)
            {
                TeacherMenu(teacher);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[X] Username yoki parol xato!");
                Console.ResetColor();
                Thread.Sleep(1500);
            }
        }

        static void TeacherMenu(dynamic teacher)
        {
            while (true)
            {
                Console.Clear();
                DrawHeader($"Xush kelibsiz, {teacher.FirstName} {teacher.LastName}!");

                Console.WriteLine("1. Yangi talaba qo'shish");
                Console.WriteLine("2. Talabalar ro'yxati");
                Console.WriteLine("3. Bo'sh o'rinlar soni");
                Console.WriteLine("0. Orqaga");

                Console.Write("\nBuyruqni tanlang: ");
                string cmd = Console.ReadLine() ?? "";

                if (cmd == "1")
                    AddNewStudent();
                else if (cmd == "2")
                    ShowAllStudents();
                else if (cmd == "3")
                    ShowStudentCount();
                else if (cmd == "0")
                    break;
            }
        }

        static void DrawHeader(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine($"   {text}");
            Console.WriteLine("========================================");
            Console.ResetColor();
        }

        public static void AddNewStudent()
        {
            Console.Write("Talaba ismi: ");
            string fn = Console.ReadLine() ?? "";
            Console.Write("Talaba familiyasi: ");
            string ln = Console.ReadLine() ?? "";
            studentService.AddStudent(fn, ln);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student muvaffaqiyatli saqlandi!");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void ShowAllStudents()
        {
            Console.Clear();
            DrawHeader("TALABALAR RO'YXATI");
            var students = studentService.GetStudents();

            Console.WriteLine(
                string.Format("{0,-10} | {1,-15} | {2,-15}", "ID", "Ism", "Familiya")
            );
            Console.WriteLine("----------------------------------------");

            foreach (var s in students)
            {
                if (s.Id == null)
                    continue;
                Console.WriteLine(
                    string.Format("{0,-10} | {1,-15} | {2,-15}", s.Id, s.FirstName, s.LastName)
                );
            }
            Console.WriteLine("\nDavom etish uchun ixtiyoriy tugmani bosing...");
            Console.ReadKey();
        }

        public static void ShowStudentCount()
        {
            int maxCapacity = 12;
            int currentCount = studentService.GetStudentCount() - 1;
            int remains = maxCapacity - currentCount;

            Console.WriteLine($"\nJami o'rin: {maxCapacity}");
            Console.WriteLine($"Hozirgi talabalar: {currentCount}");
            Console.ForegroundColor = remains > 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Qolgan o'rinlar: {remains}");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
