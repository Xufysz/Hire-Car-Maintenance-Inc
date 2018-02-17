using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_Car_Maintenance_Inc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        #region Debug code methods
        private static readonly object randNumLock = new object();
        private static readonly Random randNum = new Random();
        public static int RandomNumber(int max)
        {
            lock (randNumLock)
                return randNum.Next(max);
        }

        public static int RandomNumber(int min, int max)
        {
            lock (randNumLock)
                return randNum.Next(min, max);
        }

        private static readonly object randStringLock = new object();
        private static readonly Random randString = new Random();
        public  static string RandomString(int length)
        {
            lock (randStringLock)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //Loops chars and selects a random one until has reached length. Lambda expression
                return new string(Enumerable.Repeat(chars, length).Select(s => s[randString.Next(s.Length)]).ToArray());
            }
        }
        #endregion
    }
}
