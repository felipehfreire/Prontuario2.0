using System;
using System.ComponentModel.DataAnnotations;

namespace H1.Model.Specifications.SAP
{
    public class IsCodigoColaboradorSapExistenteSpecification : ISpecification
    {
        //injetar meu contextro
        Func<string, int> _funcIsColabSapExistente;
        public IsCodigoColaboradorSapExistenteSpecification(Func<string, int> isCodigoColaboradorSap)
        {
            _funcIsColabSapExistente = isCodigoColaboradorSap;
        }
        public ValidationResult IsSatisfiedBy(object codigoColaboradorSap)
        {
            if (_funcIsColabSapExistente(codigoColaboradorSap.ToString()) !=0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("MEWnsagem erro");
        }
    }
}
