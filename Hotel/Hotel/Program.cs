namespace Hotels;

public class Program
{
    static void Main()
    {
        Hotels hotels = new Hotels("dhbugugfe");

        while (true)
        {
            Console.WriteLine("1. Otaq yarat\n2. Əlavə et\n3. Rezerv et\n0. Çıx");
            string secim = Console.ReadLine();

            if (secim == "0") break;

            if (secim == "1" || secim == "2")
            {
                Console.Write("Ad: ");
                string name = Console.ReadLine();
                Console.Write("Qiymət: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tutum: ");
                int cap = Convert.ToInt32(Console.ReadLine());
                Room r = new Room(name, price, cap);

                if (secim == "2") hotels.AddRoom(r);
                else Console.WriteLine(r);
            }
            else if (secim == "3")
            {
                hotels.ShowAllRooms();
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                hotels.MakeReservation(id);
            }
        }
    }
}