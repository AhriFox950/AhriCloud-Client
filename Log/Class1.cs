using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace Log
{
    /// <summary>
    /// This is the main class for the program. This will return the data needed 
    /// for the logging function.
    /// [ACTION] [#] <time stamp> %message%
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// This is the method that will return the log form.
        /// </summary>
        /// <param name="message">The message to be sent.</param>
        /// <param name="action">The action stamp.</param>
        public static string log(string message, string action = "Log")
        {
            // First, cache all of the data.
            string _timestamp = DateTime.Now.ToString();
            int _actionnumber = Data.action;
            string to_return  = String.Format("[{0}} [{1}] <{2}> %{3}%",
                action, _actionnumber, _timestamp, message);  

            // Then update the action number.
            Data.action += 1;

            // Finally return the final string.
            return to_return;
   
        }
    }

    /// <summary>
    /// This holds all of the data.
    /// </summary>
    public static class Data
    {
        // This is the held action number.
        public static int action = 0;
    }
}
