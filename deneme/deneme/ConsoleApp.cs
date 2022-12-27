using deneme;

Console.Write("Eklemek İstediğiniz araç adedi giriniz");
int adet = Convert.ToInt32(Console.ReadLine());
List<Car> Araclar= new List<Car>();
for (int i = 0; i < adet; i++)
{
    Console.WriteLine("araç Markası giriniz");
    string aracMarka = Console.ReadLine();

    Console.WriteLine("araç yaşını giriniz");
    int aracyas = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("araç modeli giriniz");
    string aracModel = Console.ReadLine();
    Car car = new Car();

    car.marka = aracMarka;
    car.yas = aracyas;
    car.model = aracModel;
    Araclar.Add(car);
    


}

foreach (var item in Araclar)
{

    Console.WriteLine("Marka :" + item.marka);
    Console.WriteLine("tip :" + item.yas);
    Console.WriteLine("model :" + item.model);
    bool status = Araclar.Contains(item);
}
Console.WriteLine("MERHABA");


