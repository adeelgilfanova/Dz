using System;
namespace Zadachi
{
    class Hospital : Psychiatric
    {
        public Hospital(string name) : base(name) { }
        List<Patient> patientsList = new List<Patient>();
        List<Doctors> doctorsList = new List<Doctors>();
        public void Registry()
        {
            Console.WriteLine("Вас направили в регистратуру!");
            Console.WriteLine("Назовите свой кодовый шифр:");
            int code;
            while (!int.TryParse(Console.ReadLine(), out code))
            {
                Console.WriteLine("Вы уверены что в нашем шифре есть такие символы?");
            }
            Console.WriteLine("Шифр активирован \n Для оказания услуги пройдите в окошечко информации");
        }

        public void Information()
        {
            Console.WriteLine("Вас интересует какая-либо информация по нашей клинике?");
            Console.WriteLine("1: Да");
            Console.WriteLine("2: Нет");
            int userChoose;
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            while (userChoose == 1)
            {
                Console.WriteLine("Вы можете узнать:");
                Console.WriteLine("1.Права пациента");
                Console.WriteLine("2.Распорядок дня");
                Console.WriteLine("3.Услуги для пациентов");
                Console.WriteLine("4.Опасная зона");
                Console.WriteLine("5.Выход");
                if (!int.TryParse(Console.ReadLine(), out userChoose))
                {
                    Console.WriteLine("Вы ввели неправильно");
                }
                if (userChoose == 1)
                {
                    Console.WriteLine("Права пациента:");
                    Console.WriteLine("*Получить разъяснения по основаниям и целям помещения его в психиатрический стационар.\n*Обращаться непосредственно к главному врачу или заведующему отделением по вопросам лечения, обследования, выписки из психиатрического стационара и соблюдения прав, предоставленных Законом о психиатрической помощи.\n*Подавать без цензуры жалобы и заявления в органы представительной и исполнительной власти, прокуратуру, суд и адвокату.\n*Встречаться с адвокатом и священнослужителем наедине.\n*Исполнять религиозные обряды, соблюдать религиозные каноны, в том числе по согласованию с администрацией иметь религиозную атрибутику и литературу.\nВыписывать газеты и журналы.\n*Получать наравне с другими гражданами вознаграждение за труд в соответствие с его количеством и качеством, если пациент участвует в производительном труде.");
                }
                else if (userChoose == 2)
                {
                    Console.WriteLine("Распорядок дня:");
                    Console.WriteLine("7.00 – 9.00 – подъем, измерение температуры, утренний туалет, сдача анализов, обследования натощак.\n9.00 – 10.00 – завтрак.\n10.00 – 12.00 – обход. В это время следует находиться в палате.\n12.00 – 14.00 – процедуры.\n14.00 – 15.00 – обед.\n15.00 – 16.00 – тихий час.\n16.00 – 18.00 – отдых, процедуры.\n18.00 – 19.00 – ужин.\n19.00 – 20.00 — отдых, процедуры.\n21.00 – отход ко сну.");
                }
                else if (userChoose == 3)
                {
                    Console.WriteLine("Услуги для пациентов:");
                    Console.WriteLine("Во время пребывания в больнице могут возникнуть различные бытовые проблемы.В вестибюле центрального входа находятся:\nБуфет\nРаботает ежедневно с 9.00 до 16.00, кроме выходных.\nПарикмахерская\nНаходится на первом этаже корпуса «А».\nВремя работы с 10.00 до 16.00 ежедневно, кроме выходных.");
                }
                else if (userChoose == 4)
                {
                    Console.WriteLine("Мы очень масштабная клиники, вы наверно читали у нас сайте, что мы также лечим опасных психопатов.\n Это происходит в корпусе «Б».\nКорпус находиься под землей, поэтому опасности для пациентов не представляет. ");
                }
                else if (userChoose == 5) break;

            }
            Console.WriteLine("а,зря!");
        }

        private string[] GetInfoAboutNewPatient()
        {
            string[] allInfoAboutPatient = new string[3];
            Console.WriteLine("Введите Имя пациента:");
            allInfoAboutPatient[0] = Console.ReadLine();
            Console.WriteLine("Введите Фамилию пациента:");
            allInfoAboutPatient[1] = Console.ReadLine();
            Console.WriteLine("Введите уровень психа пациента:");
            allInfoAboutPatient[2] = Console.ReadLine();
            return allInfoAboutPatient;

        }
        public void AddPatient()
        {
            string[] allInfoAboutPatient = GetInfoAboutNewPatient();
            patientsList.Add(new Patient(patientsList.Count, allInfoAboutPatient[0], allInfoAboutPatient[1], Int32.Parse(allInfoAboutPatient[2])));
            FileReaderPeople.AddPatientInfoToFile((patientsList.Count-1) + "#" + allInfoAboutPatient[0] + "#" + allInfoAboutPatient[1] + "#" + allInfoAboutPatient[2] + "#");

        }

        public void GetPatientsForDoctors()
        {
            for (int i = 0; i < doctorsList.Count; i++)
            {
                for(int j = 0; j < patientsList.Count; j++)
                {
                    if (doctorsList[i].IsCanHeal(patientsList[j]))
                    {
                        Console.WriteLine($"Пациент {patientsList[j].lastName} был опреден доктору {doctorsList[i].lastName}");
                        doctorsList[i].AddPatient(patientsList[j]);
                    }
                }
            }
        }
    }
}

