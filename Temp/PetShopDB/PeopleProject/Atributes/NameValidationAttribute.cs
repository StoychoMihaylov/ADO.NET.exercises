using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject.Atributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class NameValidationAttribute : ValidationAttribute
    {       
        public override bool IsValid(object value)
        {
            string stringValue = (string)value;
            if (stringValue == null)
            {
                throw new ArgumentException("Property wiht attached atribute must be of type string and not null");
            }

            if (stringValue.Substring(0,1) != stringValue.Substring(0,1).ToUpper())
            {
                throw new DbEntityValidationException("First letter of name must be capital");
            }

            return true;
        }
    }
}
