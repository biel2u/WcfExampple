using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;

namespace Wcf.Service
{
    public class Validation : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "username" && password == "password")
                return;

            throw new System.IdentityModel.Tokens.SecurityTokenException("Unknown Username or Password");
        }
    }
}