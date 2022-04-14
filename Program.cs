using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    static void Main()
    {

        SortArray();
        // Step 1: - Create a class
        // Step 2: - Move GetRandomNumber() in that class
        // step 3: - Still in that class, Add function to sort the array and save it in a file

        // step 4: Have the project compiled and runnning, and return the whole project by email to mbrousseau@tnmservices.com
    }

    
    public static IList<double> GetRandomNumber(int count)
    {
        List<double> res = new List<double>();
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            res.Add(random.NextDouble()*100d);
        }
        //  res.Add(Random.NextDouble() * 100d);
           
        return res;
    }
    public static void SortArray()
    {
         
        var array = GetRandomNumber(5);
        Double[] tab=array.ToArray();
        Array.Sort(tab);
         
         
        String[] s = new String[tab.Length];

        for (int i = 0; i < s.Length; i++)
            s[i] = tab[i].ToString();
         
         
        File.WriteAllLines("new.txt", s);
        using (StreamReader sr = new StreamReader("new.txt"))
        {
            string res = sr.ReadToEnd();
            Console.WriteLine(res);
        }



    }
}