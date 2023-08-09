using System;

namespace SavingInterface 
{ 
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;

        }

        public void Display()
        {
            Console.WriteLine("Password");
            Console.WriteLine("-----");

            if (!Hidden)
                Console.WriteLine(Password);
                else
                
                Console.WriteLine(new string('*', Password.Length));

                Console.WriteLine();
        }

        public void Reset()
        {
            Password = "";

            Hidden = false;
        }
    }
}