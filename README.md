# RazorPageMovie
Un ejemplo funcional de como deberia de ser una aplicación web de Razor Pages con ASP.NET Core, tomando en cuenta sertificado ssh de base de datos no valido etc, ademas se toma en cuenta clase de contexto que se crea y comandos a realizar

#para crear la migracion
dotnet ef migrations add InitialCreate

#para aplicar cambios a la bd
dotnet ef database update --project RazorPageMovie
