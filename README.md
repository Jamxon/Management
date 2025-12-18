📚 Maktab Boshqaruv Tizimi (School Management System)
Ushbu loyiha C# dasturlash tilida yaratilgan bo'lib, o'qituvchilarni ro'yxatga olish, tizimga kirish va talabalar ma'lumotlarini boshqarish uchun mo'ljallangan konsol ilovadir.

✨ Xususiyatlari
O'qituvchilar Registratsiyasi: Yangi o'qituvchi profillarini yaratish.

Xavfsiz Kirish: Username va parol orqali tizimga kirish himoyasi.

Talabalar Boshqaruvi:

Yangi talabalarni bazaga qo'shish.

Mavjud talabalar ro'yxatini jadval ko'rinishida ko'rish.

Qabul kvotasi va bo'sh o'rinlar sonini kuzatish.

Chiroyli Interfeys: Konsol ranglari va maxsus ramkalar bilan boyitilgan foydalanuvchi interfeysi.

🛠 Texnologiyalar
Til: C# (.NET Core / .NET SDK)

Arxitektura: N-Tier (Domain, Infrastructure, Application, Client)

Ma'lumotlar saqlash: In-Memory (Vaqtinchalik xotira)

📂 Loyiha Tuzilishi
Plaintext

Management.System/
├── Management.Domain          # Modellarni o'z ichiga oladi (Student, Teacher)
├── Management.Infrastructure  # Ma'lumotlar bazasi simulyatsiyasi (DbContext)
├── Management.Application     # Biznes mantiq va servislar (StudentService, TeacherService)
└── Management.Client          # Konsol interfeysi (Asosiy dastur)
🚀 Ishga tushirish
Repozitoriyani yuklab oling yoki kodingizni IDE (Visual Studio / JetBrains Rider) da oching.

Management.Client loyihasini "Startup Project" qilib belgilang.

Dasturni ishga tushirish uchun F5 tugmasini bosing.

📖 Foydalanish yo'riqnomasi
Dastlabki kirish: Tizimda standart holatda admin / admin login paroli mavjud.

Ro'yxatdan o'tish: Agar yangi o'qituvchi bo'lsangiz, asosiy menyudan 2 ni tanlang.

Talaba qo'shish: Tizimga kirgandan so'ng "Yangi talaba qo'shish" bo'limiga o'ting va ma'lumotlarni kiriting.

Monitoring: "Bo'sh o'rinlar" bo'limi orqali jami 12 ta o'rindan nechtasi qolganini ko'rishingiz mumkin.

🎨 Interfeys ko'rinishi
Dasturda foydalanuvchiga qulaylik yaratish uchun quyidagi ranglardan foydalanilgan:

🟡 Sariq: Sarlavhalar va muhim bo'limlar.

🟢 Yashil: Muvaffaqiyatli amallar (Saqlash, Kirish).

🔴 Qizil: Xatoliklar yoki to'lgan kvotalar.

🔵 Havorang: Asosiy menyu tanlovlari.

Eslatma: Ma'lumotlar dastur yopilganda o'chib ketadi (In-Memory). Kelajakda ma'lumotlarni JSON yoki SQL bazaga saqlash imkoniyati mavjud.