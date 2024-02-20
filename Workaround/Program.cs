// See https://aka.ms/new-console-template for more information
using Bussiness.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");



static void SelamVer(string isim = "Emre") //Bu bir metoddur. void sadece işi yapar. birşey döndürmez.
                                           //== isim yazar isen default parametre olmuş olur.                   
                                           //Metodda parantez içine yazılan yere bana parametre ver gibi düşün. Xisim “merhaba” gibi
{
    Console.WriteLine("Merhaba" + isim);
}

SelamVer();
SelamVer("emre");

static int Topla(int sayi1 = 5, int sayi2 = 2)//örneğin bir krediyi hesaplarken
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam" + sonuc.ToString());
    return sonuc;
}

Topla(3, 5);

List<string> sehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
sehirler1.Add("Bursa");

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

Person person1=new Person();
person1.FirstName = "Emre";
person1.LastName = "Dağlar";
person1.NationalIdentity = 28882842068;
person1.DateOfBirth = 1996;




PttManager pttManager = new PttManager(new PersonManager());

pttManager.GiveMask(person1);

