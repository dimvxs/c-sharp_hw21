using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    delegate void AddItem(Item[] items);
    public class Bag
    {
//         Задание 2
// Создайте класс рюкзак. Характеристики рюкзака:
// ■ Цвет рюкзака;
// ■ Фирма производитель;
// ■ Ткань рюкзака;
// ■ Вес рюкзака;
// ■ Объём рюкзака;
// ■ Содержимое рюкзака (список объектов, у каждого
// объекта кроме названия нужно учитывать занимаемый объём).
// Создайте методы для заполнения характеристик. Создайте событие для 
// добавления объекта в рюкзак. Реализуйте анонимный метод в качестве
//  обработчика события добавления объекта. Если при попытке добавления
//   может быть превышен объём рюкзака, нужно генерировать исключение.
public string Color { get; set; }
public string Brand { get; set; }
public string Material { get; set; }
public double Weight { get; set; }
public double Volume { get; set; }
public Item[] Items { get; set; }


 public Bag(string color, string brand, string material, double weight, double volume, int maxItems)
    {
        Color = color;
        Brand = brand;
        Weight = weight;
        Material = material;
        Volume = volume;
        Items = new Item[maxItems];  
    }


     public void AddItemToBag(Item item)
        {
            // Анонимная функция для добавления предмета
            Action<Item> addItem = (newItem) =>
            {
                double totalVolume = 0;

                // Считаем общий объем всех предметов в рюкзаке
                foreach (var i in Items)
                {
                    if (i != null)
                    {
                        totalVolume += i.Volume;
                    }
                }

                // Проверяем, не превышает ли добавление нового предмета общий объем рюкзака
                if (totalVolume + newItem.Volume > Volume)
                {
                    throw new InvalidOperationException("Рюкзак переполнен, не удалось добавить предмет.");
                }

                // Добавляем предмет в рюкзак, если есть место
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i] == null)
                    {
                        Items[i] = newItem;
                        Console.WriteLine($"Предмет '{newItem.Name}' добавлен в рюкзак.");
                        break;
                    }
                }
            };

            // Вызов анонимной функции для добавления предмета
            addItem(item);
        }
    }

 
}