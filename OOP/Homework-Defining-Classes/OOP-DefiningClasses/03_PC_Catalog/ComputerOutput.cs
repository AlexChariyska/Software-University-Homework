using System;
using System.Collections.Generic;
using System.Linq;
class ComputerOutput
{
    static void Main(string[] args)
    {
        Component intelGraphicsCard = new Component("Intel HD Graphics 4400", "Mnogo moshtna", 499.0m);
        Component asrockMotherboard = new Component("Asrock 123412", 199.0m);
        Component intelProcessor = new Component("Intel i5 43-123512", 600.0m);

        Computer firstComp = new Computer("Lenovo", new List<Component> { intelGraphicsCard, asrockMotherboard, intelProcessor });
        Component nvidiaGraphicsCar = new Component("NVIDIA GeForce GTX 880M", " (4GB GDDR5)", (decimal)1000);
        Component inteli7Processor = new Component("Intel Core i7-4700HQ", "(4-ядрен, 2.40 - 3.40 GHz, 6MB кеш)", (decimal)300);
        Component asusMotherboard = new Component("Asus Motherboard", (decimal)200);

        Computer secondComp = new Computer("Asus", new List<Component> { nvidiaGraphicsCar, inteli7Processor, asusMotherboard });

        Component nGraphic = new Component("NVIDIA GeForce GTX 100000", " (64GB GDDR8)", (decimal)80000);
        Component processor = new Component("Intel i8 NNNN", (decimal)1000);
        Component motherboard = new Component("Motherboard", (decimal)900);

        Computer thirdComp = new Computer("HP", new List<Component> { nGraphic, processor, motherboard });

        List<Computer> computers = new List<Computer>() { firstComp, secondComp, thirdComp, };

        computers.OrderByDescending(computer => computer.Price).ToList().ForEach(computer => Console.WriteLine(computer.ToString()));
    }
}
