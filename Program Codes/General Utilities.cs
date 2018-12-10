using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    public static class GeneralUtils
    {
        /// <summary>
        /// Returns the size of ICollections or -1 if they are not an ICollection 
        /// </summary>
        /// <param name="theObject">The object that is being tested</param>
        /// <returns>The size of the object = (-1 if not an ICollection)</returns>
        public static int GetObjSize(object theObject)
        {
            // Check if object is not an IEnumerable or a string
            if (theObject is string || theObject as ICollection == null)
            {
                return -1;
            }

            // If checks pass, find the size
            return ((ICollection)theObject).Count;
        }
    }
}
