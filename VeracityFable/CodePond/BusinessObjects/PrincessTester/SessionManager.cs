using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;



namespace CodePond.BusinessObjects
{
    public class SessionManager
    {
        public SessionManager()
        {                       
        }

        public string UserName()
        {
            return System.Environment.MachineName;
        }

        
    }

    
}