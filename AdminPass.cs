using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class AdminPass
{
    public static string adminpass;
    public static void ReadPassFile()
    {
        string filePath = "passwd.txt";
        if (File.Exists(filePath))
        {
            adminpass = File.ReadAllText(filePath);
        }
        else
        {
                File.WriteAllText(filePath, "admin");
                adminpass = "admin";
        }
    }

    public static void UpdatePasswd(string newWord)
    {
        adminpass = newWord;
        string filePath = "passwd.txt";
        File.WriteAllText(filePath, adminpass);
    }

    public static string GetPasswd()
    {
        return adminpass;
    }

}
