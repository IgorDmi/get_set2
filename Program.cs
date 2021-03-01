using System;

namespace get_set2
{
    class Storage
    {
        private string _numb;
        private string _notyfication;

        public Storage()
        {
            _numb = "N/A";
            _notyfication = "N/A";
        }

        public string NUMB
        {
            get
            {
                return _no;
            }
            set
            {
                value = value.Trim();
                if (nameof(value) == null)
                {
                    throw new ArgumentException($"{value}");
                }
                else if (nameof(value) == "")
                {
                    throw new ArgumentException($"Property cannot be a empty {value}");
                }
                else if( value.Length != 6)
                {
                    throw new ArgumentException($"Wrong propery syntax {value}");
                }
                else
                {
                    _numb = value;
                }  
            }
        }
        public string Notyfication
        {
            get => _notyfication;
            set => _notyfication = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string x;
            Storage think1 = new Storage();

            Console.Write("Enter NUMB with syntax ######: ");
            x = Console.ReadLine();
            think1.NUMB = x;

            Console.Write("Enter Notyfication: ");
            x = Console.ReadLine();
            think1.Notyfication = x;

            Console.WriteLine($"SO: {think1.NUMB}");
            Console.WriteLine($"SO: {think1.Notyfication}");
        }
    }
}
