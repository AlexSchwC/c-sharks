using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;

namespace CSharks.NFEs.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly MySqlContext _dataContext;
        public UserRepository(MySqlContext context) : base(context)
        {
            _dataContext = context;
        }

        public User GetByEnterpriseId(Guid id)
        {
            return _dataContext!.Users.FirstOrDefault(user => user.EnterpriseId == id)!;
        }

        public User GetByLogin(string login)
        {
            return  _dataContext!.Users.FirstOrDefault(user => user.Login == login)!;
        }


    }
}

