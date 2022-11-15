// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            //foreach (var car in productManager.GetAll()) ;
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}