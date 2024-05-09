using TestAPI.Entities;

namespace TestAPI.Services
{
    public interface IUserService
    {
        public IEnumerable<User> getAllUsers();
        public IEnumerable<object> getUserAndProject();
        public User addUser(User user);
        public User updateUser(User user);
        public User deleteUser(int Id);
    }
}
