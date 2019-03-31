/* Jakob Rodriguez
 * ITSE 1430
 * 3/30/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IContactDatabase
    {
        /// <summary>Adds a new game.</summary>
        /// <param name="game">The game to add.</param>
        /// <returns>The new game.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="game"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="game"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        Contact Add( Contact contact );


        /// <summary>Gets a specific contact.</summary>
        /// <param name="id">The ID of the contact.</param>
        /// <returns>The contact.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        Contact Get( int id );

        /// <summary>Gets all contacts.</summary>
        /// <returns>The list of contacts.</returns>
        IEnumerable<Contact> GetAll();

        /// <summary>Removes a contact.</summary>
        /// <param name="id">The ID of the contact.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        void Remove( int id );


        /// <summary>Updates an existing contact.</summary>
        /// <param name="id">The ID of the existing contact.</param>
        /// <param name="contact">The contact to add.</param>
        /// <returns>The updated contact.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">The contact does not exist.
        /// <para>-or-</para>
        /// A contact with the same name already exists.
        /// </exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        Contact Update( int id, Contact contact);
    }
}
