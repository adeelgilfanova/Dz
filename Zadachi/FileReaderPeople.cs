using System;
namespace Zadachi
{
    public class FileReaderPeople
    {
        public static void AddPatientInfoToFile(string allInfoAboutPatient)
        {
            string text = File.ReadAllText(@".\Patients.txt");
            text += "\n" + allInfoAboutPatient;
            File.WriteAllText(@".\Patients.txt", text);
        }
        public string[] getAllPatient()
        {
            File.WriteAllText(@".\Patients.txt", "Вероника#Сидорова#4#0\nКристина#Прохорова#10#10\nФёдор#Воробьев#2#0\nМила#Александрова#5#1\nГлеб#Головин#9#8\nЕвгения#Тарасова#10#0\nСтепан#Гусев#7#3\nМария#Жилина#6#3");
            string[] mass = File.ReadAllLines(@".\Patients.txt");
            return mass;
        }
    }
}

