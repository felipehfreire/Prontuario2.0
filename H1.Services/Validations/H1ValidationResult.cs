using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Services.Validations
{
    public class H1ValidationResult 
    {
        //
        // Summary:
        //     List of errors
        public List<string> Errors { get; }
        //
        // Summary:
        //     True if the operation was successful
        public bool Succeeded { get; set; }
    }
}
