using System.Security.AccessControl;

public class CarItemVM
{
    public string Name {get;set;}
    public decimal Price {get;set;}
    public string Image {get;set;}
    public string Description {get;set;}
    public CarItemVM(string name,decimal price, string image,string description)
    {
        Name=name;
        Price=price;
        Image=image;
        Description=description;
    }

}
public class CarItemCartVM : CarItemVM
{
    public int Quantity {get;set;}

    public CarItemCartVM(string name,decimal price, string image,string description, int quantity):base(name,price,image,description)
    {
        Name=name;
        Price=price;
        Image=image;
        Description=description;
        Quantity=quantity;
    }
}
