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
    public class Contact /** : IValidatableObject **/
    {

        /// <summary>Id.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get => _name ?? "";
            set => _name = value ?? "";
        }

        /// <summary>Gets or sets the email.</summary>
        public string Email
        {
            get => _email ?? "";
            set => _email = value ?? "";
        }

        public override string ToString() => Name;


        public bool Validate()
        {
            if (!String.IsNullOrEmpty(Name) && Email.IsValidEmail())
                return true;
            return false;
        }


        /**
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            //Name
            if (String.IsNullOrEmpty(Name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));
            //E-mail
            if (Email.IsValidEmail())
                items.Add(new ValidationResult("Email is invalid.", new[] { nameof(Email) }));

            return items;
        } **/


        private string _name = "";
        private string _email = "";
    }
}
