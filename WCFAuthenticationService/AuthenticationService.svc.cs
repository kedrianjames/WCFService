using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Security;

namespace WCFAuthenticationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class AuthenticationService : IAuthenticationService
    {
        //validates a user
        public Boolean isValidCredentials(string Username, string Password)
        {

            if (Membership.ValidateUser(Username, Password) == true) return true;

            return false;

        }
    }
}
