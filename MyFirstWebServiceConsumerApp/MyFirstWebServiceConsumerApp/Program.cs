using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFirstWebServiceConsumerApp.MyFirstWebServiceReference;
namespace MyFirstWebServiceConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Service webService = new Service();
            Console.WriteLine(webService.Miprimermetodoweb("Cristian", "Bejarano"));
            Console.ReadLine();
        }
    }
}
