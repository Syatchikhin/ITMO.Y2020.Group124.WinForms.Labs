﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinFormsCourses.Syatc00M.Lab04.Exercise2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new editForm());
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст:" + Age + "\n";
        }



    }

    


}
