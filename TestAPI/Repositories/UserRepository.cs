using Microsoft.EntityFrameworkCore;
using TestAPI.Entities;

namespace TestAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDBContext _dbContext;

        public UserRepository(MyDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
        public IEnumerable<object> GetUserAndProject()
        {
            var userAndProject = from user in _dbContext.Users
                                 join project in _dbContext.Projects
                                 on user.Id equals project.UserId into userProjects
                                 from project in userProjects.DefaultIfEmpty()
                                 select new UserProjectDTO
                                 {

                                     UserId = user.Id,
                                     UserName = user.Name,
                                     ProjectName = project != null ? project.Name : null
                                 };
            return userAndProject.ToList();
        }
        public User AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User DeleteUser(int Id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == Id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();

            return user;
        }
    };

    internal class UserProjectDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ProjectName { get; set; }
    }
}
