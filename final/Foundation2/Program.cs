using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("TV", "P-01", 500, 2);
        Product product2 = new Product("Laptop", "P-02", 1000, 1);

        Address address = new Address("123 Main St", "Naju", "State", "Korea");
        Customer customer = new Customer("Levi Lee", address);

        Order order = new Order(new List<Product> { product1, product2 }, customer);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order.GetTotalPrice());
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }
        totalPrice += customer.GetShippingCost();
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetAddress().ToString();
    }
}

class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetPrice()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}


class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;


    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }


    public bool IsInKorea()
    {
        return country == "Korea";
    }


    public override string ToString()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}


class Customer
{
    private string name;

    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }


    public bool IsInKorea()
    {
        return address.IsInKorea();
    }


    public decimal GetShippingCost()
    {
        if (IsInKorea())
            return 5;
        else
            return 35;
    }

    public Address GetAddress()
    {
        return address;
    }
}
