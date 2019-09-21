using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Specifications
{
    public interface ISpecification
    {
        ValidationResult IsSatisfiedBy(object entity);
    }
}
