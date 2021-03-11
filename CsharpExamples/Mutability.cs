using System.Collections.Generic;

namespace CsharpApplication
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public bool Changed { get; set; }

        public static Person CreatePerson(string name)
        {
            return new Person
            {
                Name = name,
                Address = "Thisplace 12",
                Town = "Thetown",
                PhoneNumber = "123456",
                Changed = false
            };
        }

        public void ChangeName(string name)
        {
            this.Name = name;
            this.Changed = true;
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Person);
        }

        public bool Equals(Person p)
        {
            return
                this.Name == p.Name &&
                this.Address == p.Address &&
                this.Town == p.Town &&
                this.PhoneNumber == p.PhoneNumber &&
                this.Changed == p.Changed;

        }



    }
}