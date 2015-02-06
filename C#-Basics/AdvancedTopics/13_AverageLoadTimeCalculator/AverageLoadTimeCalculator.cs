using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We have a report that holds dates, web site URLs and load times (in seconds). Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Use double floating-point precision. 

class AverageLoadTimeCalculator
{
    static void Main()
    {

            Console.WriteLine("Write next report: ");
            string report = Console.ReadLine();
            Dictionary<string, double> sites = new Dictionary<string, double>();
            Dictionary<string, int> counter = new Dictionary<string, int>();
           
            while (report != string.Empty)
            {
                string[] list = report.Split(' ');
                string link = list[2];
                double loadTime = double.Parse(list[3]);
               
                if (!sites.Keys.Contains(link))
                {
                    sites[link] = loadTime; counter.Add(link, 1);
                }
                else
                {
                    counter[link] +=1;
                    sites[link] = sites[link] + loadTime;
                }
                Console.WriteLine("Write line:");
                report = Console.ReadLine();
            }
            foreach (string link in sites.Keys)
            {
                Console.WriteLine("{0} = {1:F7}",link,sites[link]/counter[link]);
            }              
    }
}
