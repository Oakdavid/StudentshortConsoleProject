// See https://aka.ms/new-console-template for more information
using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Implementation;
using StudentShortProject.StudentService.Implementaton;



//ProfileRepository repository = new ProfileRepository();
//Profile profile = new Profile()
//{
//    Name = "name",
//    LastName = "lastname",
//    Email = "email",
//    Gender = "male"
//};
//repository.Create("david", "tola", "email", "gender");
//Console.WriteLine($"Name: {profile.Name}, Last Name: {profile.LastName}, Gender: {profile.Gender}, Email: {profile.Email}");


ProfileService profileService = new ProfileService();
Profile profile = new Profile()
{

    Name = "name",
    LastName = "lastname",
    Email = "email",
    Gender = "male"
};
Console.WriteLine($"Name: {profile.Name}, Last Name: {profile.LastName}, Gender: {profile.Gender}, Email: {profile.Email}");



if (profile != null)
{
    Console.WriteLine($"Profile found - Name: {profile.Name}, Email: {profile.Email}");
}
else
{
    Console.WriteLine("Profile not found.");
}