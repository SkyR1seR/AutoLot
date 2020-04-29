using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLot.EF;

namespace AutoLot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Строка подключения автоматически читается из конфигурационного файла.
            using (AutoLotEntities context = new AutoLotEntities())
            {
                // Добавить новую строку в таблицу Inventory, используя нашу модель.
                context.Cars.Add(new Car()
                {
                    Color = "Black”,
                Make = "Pinto",
                    PetName = "Pete"
                });
                context.SaveChanges();
            }
        }
        private static int AddNewRecord()
        {
            // Добавить запись в таблицу Inventory базы данных AutoLot.
            using (var context = new AutoLotEntities())
            {
                try
                {
                    // В целях тестирования жестко закодировать данные для новой записи,
                    var car = new Car()
                    {
                        Make = "Yugo",
                        Color = ’’Brown", CarNickName="Brownie’'};
                    context.Cars.Add(car);
                    context.SaveChanges();
                    // В случае успешного сохранения EF заполняет поле идентификатора
                    // значением, сгенерированным базой данных,
                    return car.Carld;
                    catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                    return 0;
                }
            }

        }
