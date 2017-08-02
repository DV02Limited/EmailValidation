using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidation
{
    public class EmailValidation
    {
        public int ValidateEmail (string emailHeader, string emailSender, string expectedSender)
        {
            var regexheader = new Regex(@"Usage");

            if (regexheader.IsMatch(emailHeader) == true && emailSender == expectedSender)
            {
                return 0;
            }
            else
                return 1;
        }
    }
}
