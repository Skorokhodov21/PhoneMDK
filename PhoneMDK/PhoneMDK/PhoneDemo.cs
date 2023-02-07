using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneMDK
{
    public class PhoneDemo
    {
        public static void Main()
        {
            Phone phone1 = new Phone("9898482928", "iPhone", 8.0);
            Phone phone2 = new Phone("938123132", "Honor", 15.0);
            Phone phone3 = new Phone();

            Console.WriteLine(phone1.getNumber());
            Console.WriteLine(phone1.model);
            Console.WriteLine(phone1.weight);
            Console.WriteLine();

            Console.WriteLine(phone2.getNumber());
            Console.WriteLine(phone2.model);
            Console.WriteLine(phone2.weight);
            Console.WriteLine();

            Console.WriteLine(phone3.getNumber());
            Console.WriteLine(phone3.model);
            Console.WriteLine(phone3.weight);

            phone1.receiveCall("Мама");
            phone2.receiveCall("Папа");

        }
    }
}