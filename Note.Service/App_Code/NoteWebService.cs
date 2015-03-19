using System.Linq;
using System.Web.Services;
using Note.Data;
using Note.Data.Model;
using Note.Data.Service;

/// <summary>
/// Summary description for NoteWebService
/// </summary>
[WebService(Namespace = "http://www.sohoa.com.vn/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class NoteWebService : WebService {
    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public UserModel GetUserByName(string username)
    {
        var user = UserHs.QueryEntities(NoteManager.CurrentContext).FirstOrDefault();
        if (user != null)
            return new UserModel
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                State = user.State,
                Type = user.Type
            };
        return null;
    }
}
