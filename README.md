# 🎓 Student Management System

O'quvchilar va o'qituvchilarni boshqarish uchun oddiy console dasturi.

## 📋 Loyiha Haqida

Bu loyiha C# tilida yozilgan va Clean Architecture prinsiplaridan foydalangan holda yaratilgan. Tizim o'qituvchilarning tizimga kirishini ta'minlaydi va ular o'quvchilarni boshqarishlari mumkin.

## 🏗️ Arxitektura

Loyiha quyidagi qatlamlardan iborat:

- **Management.Domain** - Domain modellari (Student, Teacher)
- **Management.Infrastructure** - Ma'lumotlar bazasi konteksti
- **Management.Application** - Biznes logika servislari
- **Management.Client** - Console UI

## ✨ Xususiyatlar

### O'qituvchi funksiyalari:
- ✅ Tizimga kirish (Login)
- ✅ Yangi o'quvchi qo'shish
- ✅ Barcha o'quvchilarni ko'rish
- ✅ O'quvchilar sonini ko'rish

## 🚀 O'rnatish va Ishga Tushirish

### Talablar:
- .NET 6.0 yoki undan yuqori versiya
- Visual Studio 2022 yoki VS Code

### Ishga tushirish:
```bash
cd Management.Client
dotnet run
```

## 🔐 Kirish Ma'lumotlari

**Default o'qituvchi:**
- Username: `admin`
- Password: `admin`

## 📖 Foydalanish

1. Dasturni ishga tushiring
2. Username va parolni kiriting
3. Menyudan kerakli amalni tanlang:
   - `1` - Yangi o'quvchi qo'shish
   - `2` - Barcha o'quvchilarni ko'rish
   - `3` - O'quvchilar sonini ko'rish

## 📁 Loyiha Strukturasi

```
Management/
├── Management.Domain/
│   └── Models/
│       ├── Student.cs
│       └── Teacher.cs
├── Management.Infrastructure/
│   └── Data/
│       └── DbContext.cs
├── Management.Application/
│   └── Services/
│       ├── StudentService.cs
│       └── TeacherService.cs
└── Management.Client/
    └── Program.cs
```

## 🔧 Texnologiyalar

- **Language**: C# 10
- **Framework**: .NET 6.0+
- **Architecture**: Clean Architecture
- **Data Storage**: In-Memory Array

## 📝 Qo'shimcha Ma'lumotlar

### O'quvchi Modeli
```csharp
public class Student
{
    public string? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
```

### O'qituvchi Modeli
```csharp
public class Teacher
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
```

## ⚠️ Eslatmalar

- Tizim hozircha in-memory ma'lumotlar bilan ishlaydi
- Dastur har safar ishga tushganda ma'lumotlar qayta tiklanadi
- Maksimal 3 marta noto'g'ri login urinishi imkoniyati mavjud

## 🔮 Kelajakdagi Rejalar

- [ ] O'qituvchi registratsiya funksiyasi
- [ ] O'quvchilarni o'chirish va tahrirlash
- [ ] Database integratsiyasi (SQL Server)
- [ ] Parollarni shifrlash
- [ ] Logging tizimi
- [ ] User roles va permissions

## 👨‍💻 Muallif

Student Management System - Talim muassasalari uchun oddiy boshqaruv tizimi.

## 📄 Litsenziya

Bu loyiha o'quv maqsadlarida yaratilgan.

---

**Savollar yoki takliflar uchun:** Issue ochishingiz mumkin!