using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Services.H1DataAnotations
{
    public class CodigoColaboradorSAPExistente : ValidationAttribute
    {

        public CodigoColaboradorSAPExistente(string errorMessage) : base(errorMessage)
        {
        }
    }
}
