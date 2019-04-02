/* Jakob Rodriguez
 * ITSE 1430
 * 3/30/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactManager
{
    /// <summary>Represents a contact.</summary>
    public class Contact : IValidatableObject
    {
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        /// <summary>Gets or sets the email.</summary>
        public string Email //The type should validate that the data is valid.
        {
            get { return _email ?? ""; }
            set { _email = value ?? ""; }
        }

        bool IsValidEmail( string source )
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;
        }


        private string _name = "";
        private string _email = "";

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            if(IsValidEmail(_email))
            {
                yield return new ValidationResult("Invalid e-mail");
            }
            throw new NotImplementedException();
        }
    }
}
