
/////////////////// Tapsiriq 6.1



//class Book
//{
//    private string title;
//    private string author;
//    private int pageCount;

//    public string Title
//    {
//        get { return title; }
//        set { title = value; }
//    }

//    public string Author
//    {
//        get { return author; }
//        set { author = value; }
//    }

//    public int PageCount
//    {
//        get { return pageCount; }
//        set
//        {
//            if (value < 0)
//                pageCount = 10;/// default olaraq10
//            else
//                pageCount = value;
//        }
//    }

//    public Book(string title, string author, int pageCount)
//    {
//        Title = title;
//        Author = author;
//        PageCount = pageCount;
//    }

//    public void ShowInfo()
//    {
//        Console.WriteLine($"Kitabin adi: {Title}");
//        Console.WriteLine($"Muellif: {Author}");
//        Console.WriteLine($"Sehife sayi: {PageCount}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book1 = new Book("Rahat", "Rufat Quliyev", 450);
//        Book book2 = new Book("Meyve", "Rufat Quliyev", -5); //s'hif' sayi -5 verilib amma 10 olacaq
//        book1.ShowInfo();
//        Console.WriteLine();
//        book2.ShowInfo();
//    }
//}


///////////////////////////////////////// Tapsiriq 6.2

//class Appliance
//{
//    public virtual void TurnOn()
//    {
//        Console.WriteLine("The appliance is now on. ");
//    }
//    public virtual void TurnOff()
//    {
//        Console.WriteLine("The appliance is now off. ");
//    }
//}

//////WashingMachine Appliance den Miras alir

//class WashingMachine : Appliance
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Washing machine is now running...");
//    }
//}

//////Refrigerator classi Appliance den miras alir

//class Refrigerator : Appliance
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Refrigerator is now cooling ...");
//    }
//}

////// Microwave classi Appliance den miras alir

//class Microwave : Appliance
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Microwave is now heating ...");
//    }
//}

///// Esas mesele

//class Program
//{
//    static void Main()
//    {
//        /// Obyekt yaradaq
//        WashingMachine wm = new WashingMachine();
//        Refrigerator fridge = new Refrigerator();
//        Microwave microwave = new Microwave();

//        wm.TurnOn();
//        wm.TurnOff();

//        Console.WriteLine();
//        fridge.TurnOn();
//        fridge.TurnOff();
//        Console.WriteLine();
//        microwave.TurnOn();
//        microwave.TurnOff();
//    }
//}

////////////  Tapsiriq 6.3

//abstract class PaymentMethod
//{
//    public abstract void ProcessPayment(decimal amount);
//}
//    interface IRefundable
//    {
//        void Refund(decimal amount);
//    }
//class CreditCardPayment : PaymentMethod, IRefundable
//{
//    public override void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing credit card payment of ${amount}...");
//    }
//    public void Refund (decimal amount)
//    {
//        Console.WriteLine($"Refunding ${amount} to credit card...");
//    }
//}

//class PayPalPayment : PaymentMethod, IRefundable
//{
//    public override void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing PayPal payment of${amount}...");
//    }
//    public void Refund (decimal amount)
//    {
//        Console.WriteLine($"Refunding ${amount} via PayPal...");
//    }
//}

//class BitcoinPayment : PaymentMethod
//{
//    public override void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing Bitcoin payment of${amount}...");
//    }
//}

/////Esas mesele
//class Program
//{
//    static void Main()
//    {
//        /// odeme metodlari
//        PaymentMethod creditCard = new CreditCardPayment();
//        PaymentMethod paypal =new PayPalPayment();
//        PaymentMethod bitcoin = new BitcoinPayment();

//        // odenis heyata hecirek
//        creditCard.ProcessPayment(100);
//        paypal.ProcessPayment(50);
//        bitcoin.ProcessPayment(200);

//        Console.WriteLine();

//        // Yalniz Irefundable ucun refund funksiyasini isledek
//        IRefundable refundableCreditCard = new CreditCardPayment();
//        IRefundable refundablePayPal = new PayPalPayment();

//        refundableCreditCard.Refund(20);
//        refundablePayPal.Refund(10);

//    }
//}


////////////////////////////  Tapsiriq 6.4.1
using System;
using System.Collections;

//static class CurrencyConverter
//{
//    /// texmini valyuta mezenneleri teyin edek
//    private static readonly Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>
//    {
//        {"AZN", 0.59m }, //1 azn =0.59 usd
//        {"EUR", 1.08m }, // 1eur = 1.08 usd
//        {"GBP", 1.25m }, // 1gbp = 1.25 usd
//    };
//    //Valyutani USD ye cevirmek metodu
//    public static decimal ConvertToUSD (decimal amont, string currency)
//    {
//        currency = currency.ToUpper(); //Kicik herflerle daxil olarsa problem yaratmasin
//        if (exchangeRates.ContainsKey(currency))
//        {
//            return amont * exchangeRates[currency];
//        }
//        else
//        {
//            throw new ArgumentException("Desteklenmeyen valyuta novu. ");
//        }
//    }
//}

//////// Esas hisse

//class Program
//{
//    static void Main()
//    {
//        //CurrencyConverter istifade ederek valyuta cevirme
//        decimal amountInAZN = 10;
//        decimal amountInUSD = CurrencyConverter.ConvertToUSD(amountInAZN, "AZN");
//        Console.WriteLine($"{amountInAZN} AZN ={amountInUSD} USD");

//        decimal amountInEUR = 100;
//        decimal amountInUSDFromEUR = CurrencyConverter.ConvertToUSD(amountInEUR, "EUR");
//        Console.WriteLine($"{amountInEUR} EUR ={amountInUSDFromEUR} USD");

//        decimal amountInGBP = 1000;
//        decimal amountInUSDFromGBP = CurrencyConverter.ConvertToUSD(amountInGBP, "GBP");
//        Console.WriteLine($"{amountInGBP} GBP ={amountInUSDFromGBP} USD");
//        Console.WriteLine();

//    }
//}

///////////////////// Tapsiriq 6.4.2


////Warehouse<T> generic class i (yalniz class tipleri ile isleyir)
//class Warehouse<T> where T : class
//{
//    private List<T> items = new List<T>();
//    public void AddItem(T item)
//    {
//        items.Add(item);
//    }
//    //Butun Mehsullari qaytarmaq metodu
//    public List<T> GetAllItems()
//    {
//        return new List<T>(items);
//    }
//}
////Numune ucun Product class i yaradilir
//class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public Product(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }

//    public override string ToString()
//    {
//        return $"{Name} - ${Price}";
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        //Warehouse<Product> istifadesi
//        Warehouse<Product> warehouse = new Warehouse<Product>();
//        warehouse.AddItem(new Product("Laptop", 1200));
//        warehouse.AddItem(new Product("Smartphone", 800));

//        //Anbarda olan mehsulu gostermek
//        Console.WriteLine("Anbarda olan mehsullar: ");
//        foreach (var item in warehouse.GetAllItems()) 
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

/////////////////////////////////// Tapsiriq 6.5

