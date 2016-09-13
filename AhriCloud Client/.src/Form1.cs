using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhriCloud_Client
{
    public partial class Form1 : Form
    {
        private static Action NonStaticDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the method that will return the log form.
        /// </summary>
        /// <param name="message">The message to be sent.</param>
        /// <param name="action">The action stamp.</param>
        private void log(string message, string action)
        {
            // First, cache all of the data.
            string _timestamp = DateTime.Now.ToString();
            int _actionnumber = _Data.action;
            string to_return = String.Format("[{0}} [{1}] <{2}> %{3}%",
                action, _actionnumber, _timestamp, message);

            // Then update the action number.
            _Data.action += 1;

            // Finally return the final string.
            LogOut.BeginInvoke(new Action (delegate{
                LogOut.Items.Add(to_return);
            }));


        }
        protected class _Data
        {
            public static int action = 0;
        }

        /// <summary>
        /// This holds all of the logic.
        /// </summary>
        public static class Logic
        {
            /// <summary>
            /// This interperts all of the data.
            /// </summary>
            /// <param name="data">The incoming data.</param>
            public void RecData(string data)
            {
                log
            }
        }

        /// <summary>
        /// This is the response to the button being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // When the button is clicked, send the data to the system.
            // First, cache in the information, and then clear the text.
            string input = Input.Text;
            Input.Text = "";

            // Send the data.
            Logic.RecData(input);
            
        }

        private void LogOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
