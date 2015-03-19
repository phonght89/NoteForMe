using System.Linq;
using Note.Data.Model;

namespace Note.Data.Service
{
    public class UserHs
    {
        public static IQueryable<User> QueryEntities(NoteContext context)
        {
            return context.User;
        }

        public static User QueryEntity(NoteContext context, int id)
        {
            return context.User.Single(k => k.Id == id);
        }

        public static User Insert(NoteContext context)
        {
            var nd = new User();
            context.User.AddObject(nd);
            return nd;
        }
        public static void Delete(NoteContext context, long id)
        {
            var nd = context.User.Single(k => k.Id == id);
            context.User.DeleteObject(nd);
        }

        public static void Update(NoteContext context, UserModel model)
        {
            var nd = context.User.Single(k => k.Id == model.Id);
            nd.Id = model.Id;
            nd.Username = model.Username;
            nd.Password = model.Password;
            nd.State = model.State;
            nd.Type = model.Type;
            context.SaveChanges();
        }
    }
}
