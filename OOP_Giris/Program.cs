// Ram , Ekran Kartı , işlemci , Tipi , Marka ,Renk , Anakart

//int birinci_ram = 32;
//string birinci_ekran_karti = "Nvidia rtx 4050 ti";
//string birinci_islemci = "i9 110000H";
//string birinci_tip = "Masaüstü";
//string birinci_marka = "hp";
//string birinci_renk = "Gri";
//string birinci_anakart = "Msi v550";



//int    ikinci_ram = 32;
//string ikinci_ekran_karti = "Nvidia rtx 4060 ti";
//string ikinci_islemci = "i7 110000H";
//string ikinci_tip = "Dizüstü";
//string ikinci_marka = "hp";
//string ikinci_renk = "Gri";
//string ikinci_anakart = "Msi v550";


Computer computer = new Computer()
{
    ana_kart= "Msi v550",
    ekran_karti= "Nvidia rtx 4060 ti",
    islemci = "i7 110000H",
    marka = "Msi",
    ram = 32,
    renk = "Siyah",
    tip = "Dizüstü"
};

Console.WriteLine($"Bilgisayar markası {computer.marka}");
Console.WriteLine($"Bilgisayarın rami : {computer.ram}");
Console.WriteLine($"Bilgisayar rengi : {computer.renk}");
Console.WriteLine($"Bilgisayar tipi : {computer.tip}");
Console.WriteLine($"Bilgisayar tipi : {computer.islemci}");

int[] sayilar = { 1, 2, 3, 45, 6, 7, 8 };
//                0   1  2  3   4  5  6        
Console.WriteLine(sayilar);

for (int i =0; i<=6;i++)
{
    Console.WriteLine(sayilar[i]);
}


string a = "deneme";
a = "asd";
// denemeasd


string b = new string("asd");

//Console.WriteLine("birinci bilgisayar markası :"+birinci_marka);
//// String interpolation.
//Console.WriteLine("birinci bilgisayar markası :" );

//Console.WriteLine("Hello, World!");
class Computer
{
    public int ram;
    public string ekran_karti;
    public string islemci;
    public string tip;
    public string marka;
    public string renk;
    public string ana_kart;
}