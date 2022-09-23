using ConsoleApp.Data;
using ConsoleApp.Data.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopContext context = new ShopContext();

            var updatedSock = context.Socks.FirstOrDefault(x => x.Name == "Some name");

            if (updatedSock is not null)
            {
                updatedSock.Name = "Крутые тёплые носки";
                updatedSock.Price = 30;

                context.Update(updatedSock);

                context.SaveChanges();
            }

            List<Sock> result = context.Socks.ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id} | Name:{item.Name} | Color: {item.Color} | Image: {item.ImageName} | Price: {item.Price}");
            }
        }       
    }
}