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
        public static void lineChangerMinus1(string n,string f,int ed) {
            try {
                string[] l = File.ReadAllLines(f);
                l[ed-1] = n;
                File.WriteAllLines(f,l);
            } catch (Exception e) {
                _error = e.ToString();
            }
        }
        public static void InsertLine(string path,string line,int pos) {
            string[] lines = File.ReadAllLines(path);
            using (StreamWriter w = new StreamWriter(path)) {
                for (int i = 0;i < pos;i++)
                    w.WriteLine(lines[i]);
                w.WriteLine(line);
                for (int i = pos;i < lines.Length;i++)
                    w.WriteLine(lines[i]);
            }
        }
        public static void RemoveChallenges(string file) {
            try {
                string[] read = File.ReadAllLines(file);
                int startDeleteLine = 0;
                int endDeleteLine = 0;
                bool found = false;
                for (int y = 0;y < read.Length;y++) {
                    string line = read[y];
                    if (read[y].Contains("<Section name=") && read[y].Contains("Challenges")) {
                        startDeleteLine = y + 1;
                        found = true;
                    }
                    if (read[y].Contains("</Section>") && found) {
                        endDeleteLine = y + 1;
                        break;
                    }
                }
                for (int y = 0;y < read.Length;y++) {
                    if ((y >= startDeleteLine) && (y <= endDeleteLine)) {
                        Methods.lineChangerMinus1(string.Empty,file,y);
                    }
                }
            } catch (Exception e) {
                //
            }
        }
    }
}
