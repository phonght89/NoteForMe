using System.Linq;
using Note.Data.Model;

namespace Note.Data.Service
{
    public class PasswordHs
    {
        public static IQueryable<Password> QueryEntities(NoteContext context)
        {
            return context.Password;
        }

        public static Password QueryEntity(NoteContext context, int id)
        {
            return context.Password.Single(k => k.Id == id);
        }

        public static Password Insert(NoteContext context)
        {
            var nd = new Password();
            context.Password.AddObject(nd);
            return nd;
        }
        public static void Delete(NoteContext context, long id)
        {
            Password nd = context.Password.Single(k => k.Id == id);
            context.Password.DeleteObject(nd);
        }

        public static void Update(NoteContext context, PasswordModel model)
        {
            Password nd = context.Password.Single(k => k.Id == model.Id);
            nd.Id = model.Id;
            nd.Name = model.Name;
            nd.Username = model.Username;
            nd.Password1 = model.Password;
            nd.State = model.State;
            nd.Type = model.Type;
            nd.Description = model.Description;
            context.SaveChanges();
        }
    }
}
