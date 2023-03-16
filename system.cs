using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
   
        public static class system
        {
            internal static List<user> users = new List<user>();

            public static void load_users()
            {
                string path = "user.txt";
                StreamReader srr = new StreamReader(path);

                var strr = srr.ReadLine();

                while (strr != null)
                {

                    string[] m = null;
                    m = strr.Split(',');
                    string user_name = m[0];
                    string pass = m[1];
                    string name = m[2];

                    user u = new user(user_name, pass, name);
                    users.Add(u);
                    strr = srr.ReadLine();
                    srr.Close();
                }
                srr.Close();
            }
        }
    }

