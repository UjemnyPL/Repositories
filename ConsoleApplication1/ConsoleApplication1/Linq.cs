using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinqExamples
    {
        public LinqExamples() { }
        
        public void Generate()
        {
            List<Person> personsList = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person p;
                if (i%2==0)
                {
                    p = new Person("Name " + i, i + 10, true);
                }
                else
                {
                    p = new Person("Name " + i, i + 10, false);
                }
                personsList.Add(p);
            }

            var someValues = personsList.Where(a => a.isAlien != null && a.isAlien == true);

        }

        public class Alien
        {

        }

        public class Person
        {
            public Person() { }
            public Person(string name, int age)
            {
                this.Age = age;
                this.Name = name;
            }

            public Person(string name, int age, bool? isAlien)
            {
                this.Age = age;
                this.Name = name;
                this.isAlien = isAlien;
            }

            public int Age { get; set; }
            public string Name { get; set; }
            public bool? isAlien { get; set; }
        }

        public class ServicesExampleList
        {
            private List<Service> Services { get; set; }

            public ServicesExampleList()
            {
                this.Services = new List<Service>();
            }

            public void AddService(Service serviceItem)
            {
                this.Services.Add(serviceItem);
            }

            public List<Service> GetListOfServices()
            {
                return this.Services;
            }

            public void GenerateLisOfService()
            {
                this.Services.Add(new Service
                {
                    DicountValue = 10,
                    Limited = true,
                    Price = 100,
                    ServiceId = 1,
                    ServiceName = "Konsulatacja internisty"
                });

                this.Services.Add(new Service
                {
                    DicountValue = 100,
                    Limited = true,
                    Price = 250,
                    ServiceId = 2,
                    ServiceName = "Stomatologia"
                });

                this.Services.Add(new Service
                {
                    DicountValue = 100,
                    Limited = false,
                    Price = 100,
                    ServiceId = 3,
                    ServiceName = "Fizjoterapia"
                });

                this.Services.Add(new Service
                {
                    DicountValue = 150,
                    Limited = false,
                    Price = 75,
                    ServiceId = 4,
                    ServiceName = "Konsulatacja psychologa"
                });

                this.Services.Add(new Service
                {
                    DicountValue = 10,
                    Limited = false,
                    Price = 100,
                    ServiceId = 5,
                    ServiceName = "Konsulatacja laryngologa"
                });
            }
        }

        public class Service
        {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; }
            public bool Limited { get; set; }
            public decimal DicountValue { get; set; }
            public decimal Price { get; set; }
        }

    }
}
