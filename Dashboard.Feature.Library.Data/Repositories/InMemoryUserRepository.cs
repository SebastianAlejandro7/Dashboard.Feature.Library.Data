using Dashboard.Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Library.Data.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        //implementar metodos
        private static IDictionary<Guid, User> userDictionary;

        public InMemoryUserRepository()
        {
            userDictionary = new Dictionary<Guid, User>();
        }

        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
