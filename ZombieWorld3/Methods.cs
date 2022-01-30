using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieWorld3 {
    internal class Methods {
        public static string _error = string.Empty;
        public static void lineChanger(string n,string f,int ed) {
            try {
                string[] l = File.ReadAllLines(f);
                l[ed] = n;
                File.WriteAllLines(f,l);
            } catch (Exception e) {
                _error = e.ToString();
            }
        }
    }
}
