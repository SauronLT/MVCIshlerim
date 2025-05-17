using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels;

public class Room
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Room(string name, double price = 100, int personCapacity = 2)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Otağın adı boş ola bilməz!");

        if (price < 0)
            throw new ArgumentException("Qiymət mənfi ola bilməz!");

        if (personCapacity < 1)
            throw new ArgumentException("Otağın tutumu ən az 1 nəfər olmalıdır!");

        Id = _idCounter++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }

    public string ShowInfo()
    {
        return $"Otaq ID: {Id} | Adı: {Name} | Qiymət: {Price} AZN | Tutum: {PersonCapacity} nəfər | Boşdurmu?: {IsAvailable}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
