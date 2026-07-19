
namespace buoi18.Models;

public class ProductView
{
    // id, name, price, desc
    public string id { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public ProductView(string id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
}