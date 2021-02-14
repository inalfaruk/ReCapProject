using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorResult :Result
    {

        public ErrorResult(string messsage) : base(false, messsage)
        {

        }


        public ErrorResult() : base(false) //mesaj göndermek istemez isek
        {

        }
    }
}
