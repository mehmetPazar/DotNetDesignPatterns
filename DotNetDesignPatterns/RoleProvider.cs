using DotNetDesignPatterns.SingletonPattern.Models;

namespace DotNetDesignPatterns.SingletonPattern
{
    public class RoleProvider
    {
        private static RoleProvider instance;
        public static RoleProvider Instance => instance ?? (instance = new RoleProvider());
        private new List<Role> Role { get; set; }
        public int RoleCount => Role.Count;
        public async Task<List<Role>> GetCountries() => Role;
        private RoleProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();
            Role = new List<Role>()
            {
                new Role(){ RoleName = "Trainee" },
                new Role(){ RoleName = "GrowthCoach" },
                new Role(){ RoleName = "PeopleOps" },
                new Role(){ RoleName = "Admin" }
            };
        }
    }
}
