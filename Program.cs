using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonExample;

Console.WriteLine("=== TASK 1: Read single user from users.json ===");

string usersJson = File.ReadAllText("users.json");
List<User> users = JsonConvert.DeserializeObject<List<User>>(usersJson)!;

Console.WriteLine("\n=== TASK 2: Add new entry to the JSON list ===");

users.Add(new User { Name = "Anna Smith", Age = 22, City = "Berlin" });
File.WriteAllText("users.json", JsonConvert.SerializeObject(users, Formatting.Indented));
Console.WriteLine("New user added and saved to users.json");

Console.WriteLine("\n=== TASK 3: Deserialize all users and print to console ===");

string updatedJson = File.ReadAllText("users.json");
List<User> allUsers = JsonConvert.DeserializeObject<List<User>>(updatedJson)!;

foreach (User u in allUsers)
{
    Console.WriteLine($"Name: {u.Name}, Age: {u.Age}, City: {u.City}");
}

Console.WriteLine("\n=== TASK 4 & 5: Inheritance - AdminUser and RegularUser ===");

string userTypesJson = File.ReadAllText("user_types.json");

List<AdminUser> admins = JsonConvert.DeserializeObject<List<AdminUser>>(
    JObject.Parse(userTypesJson)["admins"]!.ToString())!;

List<RegularUser> regularUsers = JsonConvert.DeserializeObject<List<RegularUser>>(
    JObject.Parse(userTypesJson)["regular_users"]!.ToString())!;

Console.WriteLine("\n-- Admins --");
foreach (AdminUser a in admins)
{
    Console.WriteLine($"[{a.UserType}] Name: {a.Name}, Age: {a.Age}, City: {a.City}, Level: {a.AdminLevel}");
}

Console.WriteLine("\n-- Regular Users --");
foreach (RegularUser r in regularUsers)
{
    Console.WriteLine($"[{r.UserType}] Name: {r.Name}, Age: {r.Age}, City: {r.City}, Subscription: {r.Subscription}");
}
