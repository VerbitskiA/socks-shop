using ConsoleApp.Data;
using ConsoleApp.Data.Entities;

namespace ConsoleApp
{
    class Program
    {
        //TODO: ДЗ
        //1. Создать вторую таблицу, например ТипыНосков, и добавить отношение Носки-ТипыНосков (внешние ключи в EF)
        //2. OnModelCreating - для начального заполнения таблиц
        //3. В Main сделать меню: 1. Каталог носков. 2. Добавить элемент. 3.Удалить элемент. 4.Редактировать. 5.Выход.
        //4. Зафикисровать изменения, сделать коммит, запушить на гитхаб.

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