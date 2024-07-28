// See https://aka.ms/new-console-template for more information

//// 1. Merhaba , Nasılsın ? , İyiyim ,Sen nasılsın ? Ekrana yazan kod

//Console.WriteLine("Merhaba\nNasilsin?\nIyiyim\nSen Nasilsin?");

//// 2. Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayıp, bunların değerlerini atayıp , ekrana yazdırılmasi

//string text = "patika+";  //// degiskenlerin tanimlanamsi
//int value = 100;

//Console.WriteLine($"Metin degerinin ekrana yazdirilmasi: {text}\nTam sayi degerinin ekrana yazdirilmasi: {value}");

//// 3. Rastgele bir sayı üretip , ekrana yazdirilmasi.

//Random rnd = new Random(); //// random sayisinin olusturulmasi
//int randomNumber = rnd.Next();
//Console.WriteLine(randomNumber);

//// 4. Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırılmasi
//Random rnd = new Random();     //// random sayisinin olusturulmasi
//int randomNumber = rnd.Next();
//int result = randomNumber % 3;  //// sayinin 3'e bolumunden kalanin bulunmasi
//Console.WriteLine($"{randomNumber} sayisinin 3'e bolumunden kalan: {result}");

//// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdırilmasi
//Console.WriteLine("Kac yasinizdasiniz?");
//int userAge = Convert.ToInt32(Console.ReadLine()); //// int tip donusumu yapilmasi

//if (userAge >= 18) {            //// girilen yasin 18'e esit ve buyuk olmasi durumu
//    char bigAge = '+';
//    Console.WriteLine(bigAge);
//}

//else
//{
//    char smallAge = '-';         //// girilen yas 18'den kucukse
//    Console.WriteLine(smallAge);
//}

//// 6. Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazilmasi

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

//// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştirilmesi
//Console.Write("Lutfen ekrana ilk isim olarak 'Gulse Bırsel' yazin: "); //Kullanicidan isimlerin alinmasi
//string firstName = Console.ReadLine();
//Console.WriteLine($"Ilk isim: {firstName}");
//Console.Write("Lutfen ekrana ikinci isim olarak 'Demet Evgar' yazin: ");
//string secondName = Console.ReadLine();
//Console.WriteLine($"Ikinci isim: {secondName}");
//Console.WriteLine("---------------------------------------");
//string changeName = string.Empty; // bos string tanimlama isimleri degistirmek icin
//changeName = firstName;  // isimlerin yer degistirilmesi
//firstName = secondName;
//secondName = changeName;
//Console.WriteLine($"ilk ismin degismis : {firstName}");
//Console.WriteLine($"ikinci ismin degismis: {secondName} ");

//// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayıp. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazilmasi.
//void ValueNotReturn()

//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

//ValueNotReturn();

//// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren  metot.

//int ValueReturn(int firstNumber, int secondNumber)
//{
//    int sum = firstNumber + secondNumber;
//    return sum;
//}

//Console.WriteLine(ValueReturn(7, 8));

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlanmasi

//bool firstValue = true; // ilk bool ifade deger atanmasi

//Console.Write("Lütfen true ya da false değeri giriniz:");
//bool userInput = Convert.ToBoolean(Console.ReadLine()); // alinan girdiyi boolean ifadeye dondurme
//string result = ConvertBooleanToString(userInput); // yazilan metod ile bool iadenin degerine gore Evet yada Hayir yazilmasi
//Console.WriteLine($"Sonu: {result}");


//string ConvertBooleanToString(bool userInput) // kullanicidan alinan deger bool olup olmadiginin kontrol edilip ; bool ise Evet, bool degilse hayir yazan metod 
//{
//    if (userInput == firstValue)
//        return "Evet";
//    else
//    {
//        return "Hayir";
//    }
//}

//// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen metot
//int bigUser = 0;

//Console.Write("Birinci kisinin yasini griniz: ");
//int firstUserAge = Convert.ToInt32(Console.ReadLine()); // int degere donusturme
//Console.Write("Ikinci kisinin yasini griniz: ");
//int secondUserAge = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ucuncu kisinin yasini griniz: ");
//int thirdUserAge = Convert.ToInt32(Console.ReadLine());

//int result = BigUserFind(firstUserAge, secondUserAge, thirdUserAge); // en buyuk yasi bulan metodu cagirma
//Console.WriteLine($"En buyuk yas: {result}");

//int BigUserFind(int firstUserAge, int secondUserAge, int thirdUserAge) // 3 kisinin yasindan en buyugu bulan metod
//{
//    //int bigUser = 0;
//    if ((firstUserAge > secondUserAge) && (firstUserAge > thirdUserAge))
//    {
//        bigUser = firstUserAge;

//    }
//    else if ((secondUserAge > firstUserAge) && (secondUserAge > thirdUserAge))
//    {
//        bigUser = secondUserAge;

//    }
//    else if ((thirdUserAge > firstUserAge) && (thirdUserAge > secondUserAge)) {

//            bigUser = thirdUserAge;

//        }
//    return bigUser;
//    }

//// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen metod

//Console.WriteLine("Lutfen en buyuk sayiyi bulmak icin girmek istediginiz sayi adeti giriniz: ");
//int inputNumber = Convert.ToInt32(Console.ReadLine());//alinan degeri int dondurme


//int[] numbers = new int[inputNumber]; // girilen sayi adedini diziye atilmasi

//for (int i = 0; i < inputNumber; i++)  // girilen sayi adetine ulasincaya kadar kullanicidan sayi alinmasi
//{
//    Console.WriteLine($"{i+1}. sayiyi giriniz:");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int maxNumber = GetBigNumber(numbers); // kullanican alinan sayilari parametresiyele yazilan GetBigNumber metodunu cagirma.
//Console.WriteLine($"En buyuk sayi: {maxNumber}");

//int GetBigNumber(params int[] numbers) // params ile sinirsiz veri alinip max degeri donen metod
//{
//    return numbers.Max();
//}

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı.

//Console.Write("Lutfen ilk ismi giriniz: ");
//string firstName = Console.ReadLine();
//Console.Write("Lutfen ikinci ismi giriniz: ");
//string secondName = Console.ReadLine();

//ChangeName(ref firstName, ref secondName);// isim degistiren metod cagrilmasi


//void ChangeName(ref string firstName, ref string secondName) // alinan isimlerin yer degistiren metod
//{
//    string tempName = string.Empty;
//    tempName = firstName;
//    firstName = secondName;
//    secondName = tempName;
//    Console.WriteLine($"Birinci isim: {firstName} Ikinci isim: {secondName}");
//}

////14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen metot.

//bool checkValue = true; // bool degiskeni tanimlanamsi
//Console.Write("Lutfen bir sayi giriniz: ");
//int userInput = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(SingleEvenNumber(userInput)); //metod caprilmasi

//bool SingleEvenNumber(int userInput) // Kullanicidan aliana sayinin tek cift  durumunun kontrol edip true veya false yazdirilmasi
//{

//    if (userInput % 2 == 0)
//    {
//        return checkValue;

//    }
//    else
//    {
//        return !checkValue;
//    }
//}

//// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
//int way = 0; // degisken tanimlanmasi
//Console.Write("Lutfen hizinizi giriniz: ");
//int speedValue = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lutfen zamani giriniz: ");
//int timeValue = Convert.ToInt32(Console.ReadLine());

//int result = WayCalculate(speedValue, timeValue, out way); // metod cagrilmasi
//Console.WriteLine($"Gidilen yol: {result}");


//int WayCalculate(int speedValue, int timeValue, out int way)// Hiz zaman girdileri ile yolu hesaplayan metod
//{
//    way = speedValue * timeValue;
//    return way;
//}

//// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
//using System.Threading.Channels;
//double result; // degiskenlerin tanimlanamsi
//int circleRadius = 5;
//const double piNumber = 3.14;

//Console.WriteLine(CircleArea(circleRadius, piNumber, out result)); // dairenin alanini hesaplayan metod cagrilmasi


//double CircleArea(int circleRadius,double piNumber, out double result)// dairenin alanini hesaplayan metod yazilmasi
//{

//    result = piNumber * Math.Pow(circleRadius, 2);
//    return result;
//}


//// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
//string text = "Zaman bir GeRi SayIm";
//string upperText = text.ToUpper();// buyuk harf yapan metod cagrilmasi
//string lowerText = text.ToLower();// kucuk harf yapan metod cagrilmasi
//Console.WriteLine(upperText); 
//Console.WriteLine(lowerText);// sonuclarin ekrana yazdirilmasi

// 18 -  metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string text = "    Selamlar   "; //degisken tanimlanip, deger atanmasi
string trimText = text.Trim(); // metod ile bosluklarin silinmesi
Console.WriteLine(trimText);



