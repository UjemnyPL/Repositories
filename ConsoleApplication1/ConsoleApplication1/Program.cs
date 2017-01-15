using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinqExamples l = new LinqExamples();
            //l.Generate();

            LinqExamples.ServicesExampleList Services = new LinqExamples.ServicesExampleList();
            Services.GenerateLisOfService();
            var ListOfServices = Services.GetListOfServices();

            var onlyLimited = ListOfServices.Select(x => x.Limited == true);
            var onlyLimitedWhereClasule = ListOfServices.Where(x => x.Limited);

            #region 
            //var lista = new List<element>();


            //lista.Add(new element() { month = 1, status = 1, year = 2016 });
            //lista.Add(new element() { month = 1, status = 1, year = 2016 });
            //lista.Add(new element() { month = 1, status = 1, year = 2016 });
            //lista.Add(new element() { month = 2, status = 2, year = 2016 });
            //lista.Add(new element() { month = 2, status = 2, year = 2016 });
            //lista.Add(new element() { month = 2, status = 1, year = 2016 });

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(String.Format("misiac {0} rok {1} status {2}", item.month, item.year, item.status));
            //}

            //var newList1 = new List<element>();
            
            //    Console.WriteLine(String.Format("czy tak {0} ", lista.Where(m => m.month == 1 && m.year == 2016).All(s => s.status == 1)));

            ////newList1.Add();// Select(s=>s.)


            ////newList1.Add(lista.Where(m => m.month == 1 && m.year == 2016 && m.status == 1).ToList<element>());


            ////foreach (var item in ele)
            ////{
            ////}

            //foreach (var item in newList1)
            //{
            //    Console.WriteLine(String.Format("m {0} r {1} s {2}", item.month, item.year, item.status));
            //}

            //Console.ReadLine();
            //#endregion

            //#region interfejsy, dziedziczenie, abstrakcja
            //VideoGraphicCard card = new VideoGraphicCard(eGraphicCardsBrands.Radeon, "HD 4250");
            //var carname = card.GetName();
            //PC pecet = new PC();
            //Tv tlevision = new Tv();
            //string template = pecet.GetProcessorName(tlevision);
            #endregion

        }
    }

    class element
    {
        public int year { get; set; }
        public int month { get; set; }
        public int status { get; set; }

    }

    interface IDeviceType
    {

    }

    interface IDescription
    {
        string GetName();
        string GetModel();
    }

    interface IGpu
    {
        decimal GpuClockSpeed();
    }


    public abstract class Device: IDescription
    {
        eGraphicCardsBrands brand;
        string model;

       public Device() { }

       public Device(eGraphicCardsBrands name, string model)
        {
            this.model = model;
            this.brand = name;
        }

        public string GetName()
        {
            return Enum.GetName(typeof(eGraphicCardsBrands), this.brand);
        }

        public string GetModel()
        {
            return this.model;
        }
    }

    class PC : Device
    {
        public PC() { }

        public string GetProcessorName(IComputers name)
        {
            return name.GetProcessor();
        }
    }

    class Tv : Device, IComputers
    {
        string procName = "procek w telewizorze";
        public string GetProcessor()
        {
            return this.procName;
        }
    }

    public class VideoGraphicCard : Device, IGpu
    {
        decimal clockSpeed { get; set; }

        public VideoGraphicCard() { }

        public VideoGraphicCard(eGraphicCardsBrands brand, string model) : base(brand, model)
        {
            
        }

        public decimal GpuClockSpeed()
        {
            return this.clockSpeed;
        }
    }

    public enum eGraphicCardsBrands
    {
        Radeon = 0,
        Amd
    }

    interface IComputers
    {
        string GetProcessor();
    }

}
