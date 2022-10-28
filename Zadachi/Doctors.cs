using System;
namespace Zadachi
{
    public class Doctors : People
    {
        private int lvlPsychThatCanHeal { get; set; }
        List<Patient> patients = new List<Patient>();
        public Doctors(int id, string FirstName, string LastName, int lvlPsychThatCanHeal) : base(id, FirstName, LastName)
        {
            this.lvlPsychThatCanHeal = lvlPsychThatCanHeal;
        }
        public bool IsCanHeal(Patient patient)
        {
            return (patient.lvlPsych <= lvlPsychThatCanHeal);
        }
        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }
    }
}

