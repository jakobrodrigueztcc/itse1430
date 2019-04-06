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
        /****************************************************************************************
        Acceptance Criteria
    Main window shows a list of messages that have been sent including email address, subject and message.
    Clicking send in the send message form causes the correct information to appear in the UI.

         ****************************************************************************************/
        /// <summary>Sends message.</summary>
        /// <param name="contact">The contact the message will be sent to.</param>
        /// <returns>The message.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="contact"/> is null.</exception>
        /// <exception cref="ValidationException"><paramref name="contact"/> is invalid.</exception>
        /// <exception cref="ArgumentException">A contact with the same name already exists.</exception>
        string Send( Message message );
    }
}
