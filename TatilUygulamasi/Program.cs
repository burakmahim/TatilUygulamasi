bool newHoliday = true;
while (newHoliday)
{
    string location = "";// boş bir string
    //lokasyon seçimi
    while (location != "bodrum" && location != "marmaris" && location != "cesme" && location != "çesme" && location != "ceşme" && location != "cesme")
    {
        Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz (Bodrum/Marmaris/Çeşme)");
        location = Console.ReadLine().ToLower();
        if (location != "bodrum" && location != "marmaris" && location != "cesme" && location != "çesme" && location != "ceşme" && location != "cesme")
        {
            Console.WriteLine("Lütfen geçerli bir lokasyon giriniz.");
        }


    }

    //fiyatlandırma

    int locationPrice = 0;
    switch (location)
    {
        case "bodrum":
            locationPrice = 4000;
            break;
        case "marmaris":
            locationPrice = 3000;
            break;
        case "çeşme":
        case "çesme":
        case "ceşme":
        case "cesme":
            locationPrice = 5000;
            break;
        default:
            Console.WriteLine("hatalı lokasyon girdiniz.");
            break;
    }

    //kişi sayısı
    Console.WriteLine("Tatile kaç kişi gideceksiniz: ");
    string NumberOfPeople = Console.ReadLine();
    bool isNumberOfPeople = short.TryParse(NumberOfPeople, out short numberOfPeopleValue);

    // Ulaşım Seçimi
    int TransportPrice = 0;
    string transportType = string.Empty;
    if (isNumberOfPeople)
    {

        while (true)
        {
            Console.WriteLine("Tatiline nasıl gitmek istiyorsunuz?");
            Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
            string transport = Console.ReadLine();
            bool isTransport = short.TryParse(transport, out short transportValue);


            if (isTransport)
            {
                if (transportValue == 1)
                {
                    transportType = "Kara Yolu";
                    TransportPrice = 1500;
                    break;
                }
                else if (transportValue == 2)
                {
                    transportType = "Hava Yolu";
                    TransportPrice = 4000;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 olarak seçim yapınız.");
                }

            }
            else
            {
                Console.WriteLine("Lürfen sayı giriniz.");
            }

        }
    }

    else
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz: ");
    }

    // Toplam fiyat hesaplama
    int sumPrice = (locationPrice + TransportPrice) * numberOfPeopleValue;
    Console.WriteLine($"\nSeçtiğiniz Lokasyon: {location.ToUpper()}");
    Console.WriteLine($"Kişi Sayısı: {numberOfPeopleValue}");
    Console.WriteLine($"Ulaşım Şekli: {transportType}");
    Console.WriteLine($"Toplam Tatil Maliyeti: {sumPrice} TL");

    // Başka Tatil Planlamak İster Mi?
    Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır): ");
    string cevap = Console.ReadLine().ToLower();

    if (cevap != "evet")
    {
        newHoliday = false;
        Console.WriteLine("İyi günler!");
    }
}