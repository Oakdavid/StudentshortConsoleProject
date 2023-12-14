// See https://aka.ms/new-console-template for more information
using StudentShortProject.Entities;
using StudentShortProject.StudentRepository.Implementation;
using StudentShortProject.StudentService.Implementaton;



ProfileRepository repository = new ProfileRepository();
Profile profil = profileRepository.
Profile name = repository.Create("Sola", "Ester", "male", "yuslaw@yahoo.com");

ProfileService profileService = ProfileService();

string email = "david@email.com";

// Call the Get method
Profile profile = profileService.Get(email);

if (profile != null)
{
    Console.WriteLine($"Profile found - Name: {profile.Name}, Email: {profile.Email}");
}
else
{
    Console.WriteLine("Profile not found.");
}