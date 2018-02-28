using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class RandomDateTime
    {
        DateTime start;
        Random gen;
        int range;

        public RandomDateTime()
        {
            start = new DateTime(1960, 1, 1);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
    }

    static class GeneratePersons
    {

        static RandomDateTime rndDate = new RandomDateTime();
        static List<string> Names = new List<string>()
        {
            "Иван",
            "Федор",
            "Александр",
            "Дмитрий",
            "Игорь",
            "Павел",
            "Анатолий",
            "Сергей",
            "Виталий",
            "Даниил"
        };
        static List<string> LastName = new List<string>()
        {
            "Иванов",
            "Петров",
            "Сидоров",
            "Рожков",
            "Дроздов",
            "Степанов",
            "Ковалев",
            "Нестеров",
            "Никитин",
            "Осипов"
        };
        static List<string> MiddleName = new List<string>()
        {
            "Иосифович",
            "Филиппович",
            "Егорович",
            "Архипович",
            "Яковович",
            "Александрович",
            "Сергеевич",
            "Дмитриевич",
            "Иванович",
            "Кириллович"
        };
        static List<string> Streets = new List<string>()
        {
            "Ленинградская",
            "Липовский",
            "Солнечная",
            "пр. Героев",
            "Парковая",
            "Комсомольская",
            "Молодежная",
            "50 лет Октября",
            "Космонавтов",
            "Красных Фортов"
        };

        public static void GenerateDbContext()
        {
            Random rnd = new Random();
            using (PhoneBookDataContext db = new PhoneBookDataContext())
            {
                for (int i = 1; i < 10000; i++)
                {
                    Persons person = new Persons() { PersonId = i, FirstName = Names[rnd.Next(0, 10)], LastName = LastName[rnd.Next(0, 10)], MiddleName = MiddleName[rnd.Next(0, 10)], BornDate = rndDate.Next(), Addresses = null, Phones = null };
                    Phones phone = new Phones() { PersonId = i, Phonenumber = "8" + rnd.Next(10000, 99999).ToString()+ rnd.Next(10000, 99999).ToString()};
                    Addresses address = new Addresses() { PersonId = i, City = "Сосновый бор", Street = Streets[rnd.Next(0, 10)], House = rnd.Next(1, 60).ToString(), Flat = rnd.Next(1, 100).ToString(), HouseBlock = null, Persons = person };
                    db.Addresses.InsertOnSubmit(address);
                    db.Phones.InsertOnSubmit(phone);
                    db.Persons.InsertOnSubmit(person);
                }
                db.SubmitChanges();
            }
        }
    }
}
