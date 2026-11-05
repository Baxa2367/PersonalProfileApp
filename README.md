# PersonalProfileApp

Жеке профиль мен портфолионы көрсетуге арналған ASP.NET Core MVC веб-қосымшасы.

## Мүмкіндіктері

- Профиль туралы ақпаратты көрсету: аты-жөні, тобы, университеті, білім беру бағдарламасы және қысқаша өмірбаяны.
- Дағдылар тізімін көрсету.
- Жобалар портфолиосын сипаттамасы және қолданылған технологияларымен бірге көрсету.
- «Басты бет», «Мен туралы» және «Портфолио» беттері.

Қазіргі профиль мәліметтері `InfoController` ішінде үлгі ретінде берілген.

## Технологиялар

- C# және .NET 8
- ASP.NET Core MVC
- Razor Views
- HTML, CSS және JavaScript

## Қажетті бағдарламалар

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Іске қосу

Репозиторийді клондап, жоба бумасына өтіңіз:

```bash
git clone https://github.com/Baxa2367/PersonalProfileApp.git
cd PersonalProfileApp
```

Қосымшаны іске қосыңыз:

```bash
dotnet run --project PersonalProfileApp/PersonalProfileApp.csproj
```

Терминалда көрсетілген жергілікті URL мекенжайын браузерде ашыңыз.

## Негізгі беттер

- `/` — басты бет
- `/Info` — профиль туралы ақпарат
- `/Info/About` — «Мен туралы» беті
- `/Info/Portfolio` — портфолио

## Жоба құрылымы

```text
PersonalProfileApp/
├── Controllers/   # MVC контроллерлері
├── Models/        # Профиль және жоба модельдері
├── Views/         # Razor беттері
└── wwwroot/       # Статикалық файлдар
```
