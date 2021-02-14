using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {

        public SuccessResult(string messsage):base(true,messsage)
        {

        }


        public SuccessResult() : base(true) //mesaj göndermek istemez isek
        {

        }
    }
}
