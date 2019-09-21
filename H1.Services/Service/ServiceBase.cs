using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Services.Service
{
    public class ServiceBase
    {
        public ServiceBase()
        {
            toValidate = new List<ValidationResult>();
        }
        protected List<ValidationResult> toValidate;
    }
}
