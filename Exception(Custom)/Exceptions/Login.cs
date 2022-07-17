using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Custom_.Exceptions
{
    public class Login :Exception
    {
        public Login(string check) :base(check)
        {

        }

    }
}
