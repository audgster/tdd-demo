using System;

namespace tdddemo
{
    public class Person
    {
        public string FirstName;

        public string LastName;

        public string getFormattedName()
        {
            return $"{this.FirstName} { this.LastName}";
        }
    }
}
