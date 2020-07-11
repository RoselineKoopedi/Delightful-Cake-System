using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelightFul_Cake
{
    class FileHandler
    {
        List<Client> users = new List<Client>();

        public List<Client> Read()
        {
            StreamReader sr = new StreamReader("client.txt", true);
            string line = sr.ReadLine();
            string[] split;
            while(line !=null)
            {
                split = line.Split(',');
                users.Add(new Client(split[0], split[1], split[2], split[3],Double.Parse(split[4]), split[5], split[6],DateTime.Parse(split[7])));
                line = sr.ReadLine();
            }
            sr.Close();
            return users;
        }
        public void Write(string n, string s, string con, string c, double p, string d, string co,DateTime date)
        {
            StreamWriter sw = new StreamWriter("client.txt", true);
            string line = n + "," + s + "," + con + "," + c + "," + p + "," + d + "," + co + "," +date;
            sw.WriteLine(line);
            sw.Close();
        }
    }
}
