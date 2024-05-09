using TestAPI.Entities;

namespace TestAPI.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public IEnumerable<object> getUserAndProject();
        public User addUser(User user);
        public User updateUser(User user);
        public User deleteUser(int Id);
    }
}