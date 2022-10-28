using System;
namespace Zadachi
{
    public class People
    {
        private int id;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public People(int id, string allInfo)
        {
            this.id = id;
            InsertAllInfo(allInfo);
        }
        public People(int id, string FirstName, string LastName)
        {
            this.id = id;
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        private void InsertAllInfo(string allInfo)
        {
            string[] allInfoMass = allInfo.Split('#');
            firstName = allInfoMass[0];
            lastName = allInfoMass[1];
        }
    }
}

