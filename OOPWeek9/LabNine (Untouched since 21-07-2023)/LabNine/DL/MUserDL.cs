using BusinessApp.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.DL
{
    internal class MUserDL
    {
        private static List<MUser> userList = new List<MUser>();

        public static void addUserToList(MUser user)
        {
            userList.Add(user);
        }
        public static MUser SignIn(MUser user)
        {
            foreach (var storedUser in userList)
            {
                if(storedUser.getUserName() == user.getUserName() && storedUser.getUserPassword() == user.getUserPassword())
                    return storedUser;
            }
            return null;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        public static bool readDataFromFile(string path)
        {
            if(File.Exists(path))
            {
                StreamReader Reader = new StreamReader(path);
                string record;
                while((record = Reader.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    MUser user = new MUser(userName, userPassword, userRole);
                    addUserToList(user);
                }
                Reader.Close();
                return true;
            }
            return false;
        }
        public static void storeUserIntoFile(string path, MUser user)
        {
            StreamWriter Writer = new StreamWriter(path, true);
            Writer.WriteLine(user.getUserName() + "," + user.getUserPassword() + "," + user.getUserRole());
            Writer.Flush();
            Writer.Close();
        }
    }
}
