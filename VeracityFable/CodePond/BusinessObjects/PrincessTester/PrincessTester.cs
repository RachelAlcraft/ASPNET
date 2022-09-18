using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodePond.BusinessObjects
{
    public class PrincessTester
    {
        private bool _isPrincess = false;
        public bool IsPrincess
        {
            get
            {
                return _isPrincess;
            }
            set
            {
                _isPrincess = value;
            }

        }

        private string _name = "";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }

    
    }
}