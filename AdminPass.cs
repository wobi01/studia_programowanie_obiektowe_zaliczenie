using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class AdminPass
{
    public static string fileName = "passwd.txt";
    public static string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
    public static string adminpass = File.ReadAllText(filePath);

    public AdminPass()
    {
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
