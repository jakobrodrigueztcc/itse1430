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
    interface IMessageService
    {

        /// <summary>Sends message.</summary>
        /// <param name="game">The contact the message will be sent to.</param>
        /// <returns>The message.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="game"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        Contact Send( Contact contact );
    }
}
