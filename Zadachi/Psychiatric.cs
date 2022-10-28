using System;
namespace Zadachi
{
    public abstract class Psychiatric
    {
        public string Name { get; set; }
        public Psychiatric(string name)
        {
            Name = name;
        }
    }
}

