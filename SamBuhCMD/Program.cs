using ClassSamBuh.Controller;
using ClassSamBuh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamBuhCMD
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("С Возвращением !");
           

            Console.WriteLine("Введите название контрагента"  );

            var NameAgent = Console.ReadLine();

            Console.WriteLine("Введите номер действующего договора");

            int NumberOfContract = int.Parse (Console.ReadLine());

            var controller = new Controller(NameAgent, NumberOfContract);
            controller.SaveAgent();


            Console.ReadLine();

            Console.WriteLine(NameAgent, +  NumberOfContract);
            Console.ReadLine();






        }
        



            


        
    }
}
