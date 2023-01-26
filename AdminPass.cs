using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class AdminPass
{
    public static string filePath = "passwd.txt";
    public static string adminpass = "";

    public AdminPass()
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "admin");
            adminpass = "admin";
        }
        else
        {
            adminpass = File.ReadAllText(filePath);
        }
    }

    public static void UpdatePasswd(string newWord)
    {
        adminpass = newWord;
        File.WriteAllText(filePath, adminpass);
    }

    public static string GetPasswd()
    {
        return adminpass;
    }
}
