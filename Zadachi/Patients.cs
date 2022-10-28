using System;
namespace Zadachi
{
    public class Patient : People
    {
        public int lvlPsych { get; set; }
        public Patient(int id, string FirstName, string LastName, int LvlPsych) :base(id, FirstName, LastName)
        {
            this.lvlPsych = LvlPsych;
        }
    }
}

