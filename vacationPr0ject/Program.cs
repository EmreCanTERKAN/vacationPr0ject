while (true)
{
    //location değişkenine gitmek istedikleri yeri atıyoruz..
    Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: \n1 - Bodrum \n2 - Marmaris \n3 - Çeşme");
    string location = Console.ReadLine().Trim().ToLower();

    int basePrice = 0; // Başlangıç bakiyesi değeri atıyoruz.
    string locationName = "";

    if (location == "bodrum") // eğer bodrum seçilirse bakiyesine 4000 ilave ediyoruz.
    {
        basePrice = 4000;
        locationName = "Bodrum";
    }
    else if (location == "marmaris") // eğer marmaris seçilirse bakiyesine 3000 ilave ediyoruz.
    {
        basePrice = 3000;
        locationName = "Marmaris";
    }
    else if (location == "çeşme") // eğer Çeşme yazılırsa bakiyesine 5000 ekliyoruz.
    {
        basePrice = 5000;
        locationName = "Çeşme";
    }
    else // kullanıcı farklı bir değer atadığı zaman döngü uyarı verip continue keywordu ile başa döndürüyor.
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli bir lokasyon ismi giriniz: Bodrum, Marmaris, Çeşme");
        continue;
    }

    Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
    int personCount;
    while (!int.TryParse(Console.ReadLine(), out personCount) || personCount <= 0) // döngü şartını ! ile başlatıp int değer girmediği veya personcout değişkenini sıfırdan küçük veya negatif girdiğinde döngü şartı true olacağından dolayı aksi olmadığı sürece sınırsız tekrarlayacaktır.
    {
        Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz.");
    }

    Console.WriteLine($"{locationName} lokasyonunu seçtiniz. Bu tatil için {personCount} kişi planlıyorsunuz.");

    Console.WriteLine("Tatilinize nasıl gitmek istersiniz?\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    int transportType;
    while (!int.TryParse(Console.ReadLine(), out transportType) || (transportType != 1 && transportType != 2))
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen '1' ya da '2' seçeneklerinden birini seçiniz.");
    }

    int transportCost = transportType == 1 ? 1500 : 4000; // ternary operatörü ile bir koşul veriliyor. transportCost değişkenine transportType eğer ki 1 ise 1500, değilse 4000 değeri atanır.

    int totalCost = basePrice + (transportCost * personCount);  // toplam maliyet diye değişken tanımlanır = fiyat hesaplanır. 

    Console.WriteLine($"Seçtiğiniz lokasyon: {locationName}");
    Console.WriteLine($"Kişi sayısı: {personCount}");
    Console.WriteLine($"Ulaşım türü: {(transportType == 1 ? "Kara yolu" : "Hava yolu")}");
    Console.WriteLine($"Toplam maliyet: {totalCost} TL");

    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
    string anotherPlan = Console.ReadLine().Trim().ToLower();

    if (anotherPlan != "evet")
    {
        Console.WriteLine("İyi günler dileriz.");
        break;
    }
}