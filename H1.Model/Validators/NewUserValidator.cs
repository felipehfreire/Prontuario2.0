using H1.Model.Specifications;
using H1.Model.Specifications.SAP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Validators
{
    public class NewUserValidator 
    {
        private IsCodigoColaboradorSapExistenteSpecification IsCodigoColaboradorSapExistente;
        private List<ISpecification> especificationsList;

        public NewUserValidator(Func<string, int> codigoColaboradorSap)
        {
            //add all specifications
            especificationsList.Add(new IsCodigoColaboradorSapExistenteSpecification(codigoColaboradorSap));
            
        }
        public List<ValidationResult> Validator(object arg)
        {

            foreach (var item in especificationsList)
            {
                item.IsSatisfiedBy(arg);
            }
            //IsCodigoColaboradorSapExistente.IsSatisfiedBy(codigoColaboradorSap.ToString());
            return null;
        }
    }
}
