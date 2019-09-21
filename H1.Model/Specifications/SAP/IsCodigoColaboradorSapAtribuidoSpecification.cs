using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Specifications.SAP
{
    public class IsCodigoColaboradorSapAtribuidoSpecification : ISpecification
    {
        //injetar meu contextro
        Func<string, int> _funcIsColabSapAtribuido;
        public IsCodigoColaboradorSapAtribuidoSpecification(Func<string, int> isCodigoColaboradorSap)
        {
            _funcIsColabSapAtribuido = isCodigoColaboradorSap;
        }
        public ValidationResult IsSatisfiedBy(object codigoColaboradorSap)
        {

            if (_funcIsColabSapAtribuido(codigoColaboradorSap.ToString()) !=0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("MEWnsagem erro");
        }
    }
}
