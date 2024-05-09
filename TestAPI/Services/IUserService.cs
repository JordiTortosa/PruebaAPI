using TestAPI.Entities;

namespace TestAPI.Services
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();
        public IEnumerable<object> GetUserAndProject();
        public User AddUser(User user);
        public User UpdateUser(User user);
        public User DeleteUser(int Id);
    }
}
