using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidJarl_MVC_2016_06
{
    public class CreditLimitValidator : ValidationAttribute
    {
        public virtual bool IsValid(decimal value)
        {
            decimal ValidValueFirst = 50000;
            decimal ValidValueSecond = 100000;

            

            if (value == null)
                return false;
            
            

            if (value == ValidValueFirst)
                return true;

            if (value == ValidValueSecond)
                return true;

            else return false;
        }
    }
}
