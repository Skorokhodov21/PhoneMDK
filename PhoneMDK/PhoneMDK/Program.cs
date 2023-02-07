using System;

namespace PhoneMDK
{
    public class Phone
    {
        public string model { get; set; }
        public string number { get; set; }
        public double weight { get; set; }

        public Phone(string n, string m, double w)
        {
            number = n;
            model = m;
            weight = w;
        }

        public Phone(string n, string m)
        {
            model = m;
            number = n;
        }

        public Phone() { }

        public void receiveCall(string name)
        {
            Console.WriteLine("Calling " +  name);
        }

        public string getNumber()
        {
            return number;
        }

    }
}
