
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable data = new Hashtable();
        data.Add(1,"Praveen");
        data.Add(2,"Kumar");
        data.Add(3,12.3f);
        data.Add("A1",100);
        // System.Console.WriteLine(data["A1"]);
        foreach (DictionaryEntry item in data)
        {
            System.Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}