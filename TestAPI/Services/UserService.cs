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
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public IEnumerable<object> GetUserAndProject()
        {
            return _userRepository.GetUserAndProject(); ;
        }
        public User AddUser(User user)
        {
            _userRepository.AddUser(user);
            return user;
        }
        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
        
        public User DeleteUser(int Id)
        {
            return _userRepository.DeleteUser(Id);
        }
    }
}
