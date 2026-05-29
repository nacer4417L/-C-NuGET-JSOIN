namespace JsonExample;

public class User
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string City { get; set; } = "";
}

public class AdminUser : User
{
    public string UserType { get; set; } = "Admin";
    public string AdminLevel { get; set; } = "";
}

public class RegularUser : User
{
    public string UserType { get; set; } = "User";
    public string Subscription { get; set; } = "";
}
