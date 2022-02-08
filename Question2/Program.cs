using System;
class TimePeriod
{
    private double _seconds;

    public double Hours
    {
        get { return _seconds / 3600;}
        set {
            if(value < 0 || value > 24)
            throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24");

            _seconds = value * 3600;
        }
    }

}

public class SaleItem
{
   string _name;
   decimal _cost;

   public SaleItem(string name, decimal cost)
   {
      _name = name;
      _cost = cost;
   }

   public string Name
   {
      get => _name;
      set => _name = value;
   }

   public decimal Price
   {
      get => _cost;
      set => _cost = value;
   }
}

public class SaleItems
{
   public string Name
   { get; set; }

   public decimal Price
   { get; set; }
}


class Program
{
    static void Main()
    {
        TimePeriod t = new TimePeriod();
        t.Hours = 24;
        Console.WriteLine($"Time in hours : {t.Hours}"); 

        var item = new SaleItem("Laptop", 199.55m);
        Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");

        var newItem = new SaleItems{ Name = "A.C.", Price = 150.23m };
        Console.WriteLine($"{newItem.Name}: sells for {newItem.Price:C2}");
    }
}

