using System.ComponentModel;
using System.Web.Http;

namespace Survey.WebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected bool IsAdmin()
        {
            return true;
        }

        protected string GetUserName()
        {
            return "sh.abedi";
        }
    }
}