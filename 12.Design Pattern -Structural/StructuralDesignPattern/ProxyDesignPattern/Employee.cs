
namespace ProxyDesignPattern
{
    public class Employee
    {
        public Employee(string username,string password,string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }


        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }

    }
}
