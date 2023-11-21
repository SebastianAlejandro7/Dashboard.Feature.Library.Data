using Dashboard.Library.Model.Entities;

namespace Dashboard.Library.Data.Repositories
{
    public interface IUserRepository
    {// Retorno NameMetodo (Parametro);
        User Create (User user);

        List<User> Get();

        User Get(Guid id);

        void Delete(Guid id);

        void Update(Guid id, User user);
    }
}
