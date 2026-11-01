# Қарлығаш · PersonalProfileApp

Қарлығаштың .NET 8 / ASP.NET Core MVC негізіндегі шағын жеке визиткасы.

- Университет: Абай атындағы университет.
- Мамандық: ИСК. Топ: ИСК242.
- Email: karlygash_abdiyeva@mail.ru.
- GitHub профилі: [Karlygash07](https://github.com/Karlygash07).

Жас, туған жер, жұмыс тәжірибесі және жетістіктер қосылмаған. Дағдылар оқу барысында үйреніп жүрген технологиялар ретінде көрсетілген. Портфолиода осы визитка жобасы ғана бар; репозиторий сілтемесі берілмегендіктен бос қалдырылған.

## Іске қосу

Visual Studio 2022-де `PersonalProfileApp.sln` ашыңыз. ASP.NET and web development workload-ы мен .NET 8 SDK қажет. Іске қосу профилі — **http**, батырма — **Ctrl+F5**.

Терминалда, solution тұрған бумада:

```powershell
dotnet restore PersonalProfileApp.sln
dotnet build PersonalProfileApp.sln
dotnet run --project PersonalProfileApp --launch-profile http
```

Браузер: `http://localhost:5080`. Қолданбаны тоқтату: `Ctrl+C`. Бұрынғы нұсқа ашық болса, оны тоқтатып, жаңадан іске қосыңыз.

## Үш бет

| Маршрут | Мазмұны |
| --- | --- |
| `/` немесе `/Info/Index` | Қысқаша таныстыру және визитка |
| `/Info/About` | Өзі туралы мәлімет және білім |
| `/Info/Portfolio` | Оқу жобасы |

Барлық бетте ортақ footer арқылы оқу мәліметтері, үйреніп жүрген технологиялар және байланыс көрінеді.

## Деректер мен MVC

- `Data/StudentProfileData.cs` — барлық жеке ақпаратты бір жерден өзгерту.
- `Models/StudentProfile.cs` — студент моделі; `StudentProject.cs` — жоба моделі.
- `Controllers/InfoController.cs` — Index, About, Portfolio Action-дары модельді `View(profile)` арқылы береді.
- `Views/Info/*.cshtml` — `@model StudentProfile` қолданатын strongly typed Razor беттері.
- `Views/Shared/_Layout.cshtml` — ортақ навигация, мәліметтер және байланыс.
- `_ViewStart.cshtml` Layout тағайындайды; `_ViewImports.cshtml` модель namespace-ін және Tag Helper-лерді қосады.
- `wwwroot/css/site.css` — жаңа ақшыл қызғылт дизайн, дөңгелек визитка, мобильді орналасу.
- `wwwroot/js/site.js` — бөлімдердің бір рет жұмсақ ашылуы. JavaScript болмаса, мазмұн көрінеді. Reduced motion кезінде қозғалыс өшеді.

`Program.cs`: `AddControllersWithViews()` MVC сервистерін тіркейді, `UseStaticFiles()` CSS/JS береді, `UseRouting()` маршрутты таңдайды. `MapControllerRoute()` ішіндегі `{controller=Info}/{action=Index}/{id?}` басты URL-ды Info/Index-ке бағыттайды. `Run()` серверді іске қосады. Development ортасында диагностикалық қате беті, Production ортасында жалпы қате өңдеу, HSTS және HTTPS redirect бар.

Дерекқор, тіркелу және авторизация қолданылмайды.

## GitHub және Classroom

Бұл — жергілікті Қарлығаш нұсқасы. Karlygash07 аккаунтына жүктелген жоқ. Бұл бөлек жобаға бұрынғы портфолионың Git тарихы кірмейді.

Қарлығаштың бөлек репозиторийін жасап, соған жүктегеннен кейін Classroom-ға **сол репозиторийдің негізгі URL-ын** тапсыру керек. Профиль немесе localhost URL-ын тапсырмаңыз. `.gitignore` build нәтижелерін, IDE баптауларын және жеке файлдарды елемейді.

Тексеру нәтижелері: [docs/VERIFICATION.md](docs/VERIFICATION.md).
