//Console.WriteLine("Lütfen Adınızı giriniz: ");
//string name = Console.ReadLine();

//Console.WriteLine("Lütfen Soyadınızı giriniz : ");
//string surname = Console.ReadLine();


//Console.WriteLine("Adınız : "+name+" Soyadınız: "+surname);


Console.WriteLine("Lütfen 1-7 arasında bir sayı giriniz.");
int day =Convert.ToInt32(Console.ReadLine());


string dayName = "";

//if (day == 1)
//{
//    dayName = "Pzt";
//}

//else if (day==2)
//{
//    dayName = "Salı";
//}
//else if (day == 3)
//{
//    dayName = "Çarşamba";
//}
//else if (day == 4)
//{
//    dayName = "Perşembe";
//}
//else if (day == 5)
//{
//    dayName = "Cuma";
//}
//else if (day == 6)
//{
//    dayName = "Cumartesi";
//}
//else if (day == 7)
//{
//    dayName = "Pazar";
//}
//else
//{
//    Console.WriteLine("Lütfen değer aralığını aşmayınız.");
//}

//switch (day)
//{
//    case 1:
//        dayName = "Pzt";
//        break;
//    case 2:
//        dayName = "Salı";
//        break;
//    case 3:
//        dayName = "Çarşamba";
//        break;
//    case 4:
//        dayName = "Perşembe";
//        break;
//    case 5:
//        dayName = "Cuma";
//        break;
//    case 6:
//        dayName = "Cumartesi";
//        break;
//    case 7:
//        dayName = "Pazar";
//        break;

//    default:
//        dayName = "Lütfen 1-7 arasında sayı giriniz.";
//        break;
//}



//Console.WriteLine(dayName);

// switch expression

string result = day switch
{
    1 => "Pazartesi",
    2 => "Salı",
    3 => "Çarşamba",
    4 => "Perşembe",
    5 => "Cuma",
    6 => "Cumartesi",
    7 => "Pazar",
    _ => "Geçersiz karakter."
};

Console.WriteLine(result);






