
#region Notes

#region ConnectionStr

// Server=localhost;Database=AcademyDB;Trusted_Connection=True;TrustServerCertificate=True;
#endregion

#region PackageManagerConsole

//Scaffold-DbContext ‘connectionString’ Microsoft.EntityFrameworkCore.[Provider] -Force => Scaffold prosesini həyata keçirmək üçün.

// add-migration 'MigartionName'
// update-database => Code tərəfdə etdiyimiz dəyişikliklərin Databaseə yansıtmaq üçün
// update-database 'MigartionName' =>
// remove-migration

#endregion

#region DotNetCLI
//dotnet tool install --global dotnet-ef => DotNet command-ları yazabilmək üçün
//dotnet ef dbcontext scaffold ‘connectionString’ Microsoft.EntityFrameworkCore.[Provider]  => Scaffold prosesini həyata keçirmək üçün.

//dotnet ef migrations add 'MigrationName'
//dotnet ef database update
//dotnet ef database update 'MigrationName'
//dotnet ef migrations remove 'MigrationName'



#endregion

#region Packages
//Microsoft.EntityFrameworkCore
//Microsoft.EntityFrameworkCore.[Provider] => Hansı SqlProvider istifadə edəcəyiksə Provider yerinə o yazılacaq məs. SqlServer
//Microsoft.EntityFrameworkCore.Tools => Package Manager Console istifadə edəcəyiksə.
//Microsoft.EntityFrameworkCore.Design => DotNet CLI istifadə edəcəyiksə.
#endregion

#endregion

using Microsoft.EntityFrameworkCore;
using RNET104_02082024.Business;
using RNET104_02082024.Business.Abstractions.Repositories;
using RNET104_02082024.Business.Concretes.Repositories;
using RNET104_02082024.Contexts;
using RNET104_02082024.Models;

/*Student student = new()
{
    FirstName = "Test",
    LastName = "Test",
    Username = "Test",
    Password = "Test",
    DateOfBirth = DateTime.Now,
    EnrollmentDate = DateTime.Now,
};
StudentService studentService = new();
studentService.AddStudent(student);*/





int id = Convert.ToInt32(Console.ReadLine());
IReadRepository<Teacher> teacherReadRepository = new ReadRepository<Teacher>();
IReadRepository<Student> studentReadRepository = new ReadRepository<Student>();

Console.WriteLine(studentReadRepository.GetById(1).FirstName);