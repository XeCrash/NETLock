using System;
using System.IO;
using System.Text;

/*
 * Read the read me or look at the example applications if you want to know how to use this to protect youself from
 * modified or cracked file versions of NETLock.dll from being used on your application. -XeCrash
 * 
 * Created On: Tuesday, September 19th, 2017 at 4:18:48 AM EST
 * 
 * Special thanks to SDK from BetterSeal!
 */ 

public class InnerLock
{
    private static string CurrentMD5 = ""; //You would put the MD5 value you obtained from the MD5 file checker in the admin panel
    public static void Check()
    {
        if (ComputeHash($"{AppDomain.CurrentDomain.BaseDirectory}NETLock.dll") != CurrentMD5)
        {
            Environment.Exit(2134);
        }
    }

    private static string ComputeHash(string s)
    {
        using (var md5 = System.Security.Cryptography.MD5.Create())
        {
            using (var stream = File.OpenRead(s))
            {
                byte[] hash = md5.ComputeHash(stream);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
