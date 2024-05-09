using TestAPI.Entities;
using TestAPI.Repositories;

namespace TestAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IEnumerable<User> getAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public IEnumerable<object> getUserAndProject()
        {
            return _userRepository.getUserAndProject(); ;
        }
        public User addUser(User user)
        {
            _userRepository.addUser(user);
            return user;
        }
        public User updateUser(User user)
        {
            return _userRepository.updateUser(user);
        }
        
        public User deleteUser(int Id)
        {
            return _userRepository.deleteUser(Id);
        }
    }
}
