using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class UsefulAcquaintances
    {
        /*
         * сделать словарь, в котором по двум первым буквам имени можно найти все записи email адресов из его дневника.
         */
        //public static Dictionary<string, List<string>> OptimizeContacts2(List<string> contacts)
        //{
        //    //Первый вариант, но почемкто с ошибкой
        //    //var dictionary = new Dictionary<string, List<string>>();

        //    //foreach (var e in contacts)
        //    //{
        //    //    var subString = string.Concat(e.Split(':')[0].Take(2));

        //    //    if (!dictionary.ContainsKey(subString))
        //    //        dictionary.Add(subString, 
        //    //            contacts.Where(x => x.StartsWith(subString)).ToList());
        //    //}

        //    //Второй вариант, но почемуто с ошибкой
        //    var dictionary = new Dictionary<string, List<string>>();

        //    foreach (var contact in contacts)
        //    {
        //        var name = contact.Split(':')[0];
        //        string subString = null;

        //        if (name.Length <= 2)
        //            subString = name;
        //        subString = name.Substring(0, 2);

        //        if (dictionary.ContainsKey(subString))
        //            dictionary[subString].Add(contact);

        //        else
        //            dictionary[subString] = new List<string>() {contact};
        //    }

        //    foreach (var e in dictionary)
        //    {
        //        Console.WriteLine(dictionary.Keys + "\t" + dictionary.Values);
        //    }

        //    return dictionary;
        //}

        //правильный вариант
        public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var e in contacts)
            {
                var parsedContact = e.Split(':');
                var key = e.Substring(0, Math.Min(2, parsedContact[0].Length));
                //var key = e.Substring(0, 2); ?? 

                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = new List<string>();
                }

                dictionary[key].Add(e);
            }

            return dictionary;
        }
    }
}