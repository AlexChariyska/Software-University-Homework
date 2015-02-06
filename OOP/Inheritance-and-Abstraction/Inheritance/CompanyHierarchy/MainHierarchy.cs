
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainHierarchy
    {
        static void Main()
        {

            IProject project1 = new Project(
                "Project 1",
                "01-09-2011",
                State.Closed ,
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris ac sollicitudin metus, ut fermentum risus. Donec sem urna, auctor eget risus in, interdum commodo felis");

            IProject project2 = new Project(
               "Project 2",
               "12-09-2014",
               State.Open,
               "Suspendisse potenti. Maecenas metus augue");

            IProject project3 = new Project(
               "EShop ASP.Net",
               "25-02-2013",
               State.Open,
               "Aenean luctus tincidunt urna at pulvinar. ");

            ISales sale1 = new Sales("Sale 1", new DateTime(2014, 08, 15), 2340);
            ISales sale2 = new Sales("Sale 2", new DateTime(2014, 03, 10), 220);
            ISales sale3 = new Sales("Sale 3", new DateTime(2013, 07, 25), 2000.50);
            ISales sale4 = new Sales("Sale 4", new DateTime(2014, 09, 5), 1800.50);
           

            IEmployee pesho = new SalesEmployee(
               "Petur",
               "Petrov",
               987456,
               20000,
               DepartmentsEnum.Sales,
               new List<ISales>() { sale1, sale3 });

            IEmployee gosho = new SalesEmployee(
               "Gosho",
               "Georgiev",
               123456,
               24000,
               DepartmentsEnum.Sales,
               new List<ISales>() { sale2, sale4 });

            IEmployee marina = new SalesEmployee(
               "Marina",
               "Marinka",
               666666,
               30000,
               DepartmentsEnum.Marketing,
               new List<ISales>() { sale1 });

            IEmployee mitko = new Developer(
               "Mitko",
               "Mitkov",
               999999,
               28000,
               DepartmentsEnum.Production,
               new List<IProject>() { project3, project2 });

            IEmployee minka = new Developer(
               "Minka",
               "Minkova",
               000001,
               15000,
               DepartmentsEnum.Production,
               new List<IProject>() { project1,project2 });

            IManager kiril = new Manager(
               "Kiril",
               "Dimitrov",
               112250,
               38000,
               DepartmentsEnum.Production,
               new List<IEmployee>() { mitko, minka, });

            IManager alex = new Manager(
              "Alexandra",
              "Malinova",
              112213,
              30000,
              DepartmentsEnum.Production,
              new List<IEmployee>() { minka });

            IManager peshoM = new Manager(
           "Pesho",
           "Peshov",
           111111,
           35000,
           DepartmentsEnum.Marketing,
           new List<IEmployee>() { pesho, gosho, marina });

            IList<IEmployee> employees = new List<IEmployee>() { 
            pesho, gosho, marina, peshoM, alex, kiril, minka, mitko, };

            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("\n\n");
            }
        }
    }
}

