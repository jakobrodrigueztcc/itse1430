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


        private string _name = "";
        private string _email = "";
    }
}
