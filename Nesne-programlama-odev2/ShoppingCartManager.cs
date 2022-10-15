namespace Nesne_programlama_odev2;

public class ShoppingCartManager
{
    private List<CartItem> _cartItems;

    public ShoppingCartManager()
    {
        _cartItems = new List<CartItem>();
    }

    public void Add(CartItem item)
    {
        _cartItems.Add(item);
    }

    public void Remove(int id)
    {
        var item = _cartItems.FirstOrDefault(item => item.Id == id);
        if (item == null) throw new Exception("Eleman Bulunamadı");
        _cartItems.Remove(item);
    }

    public void GetBalance()
    {
        Console.WriteLine($"Toplam Fiyat : {_cartItems.Sum(item => item.Product.Price * item.Quantity)}");
    }

    public void GetList()
    {
        _cartItems.ForEach(item => Console.WriteLine(item));
    }
    
}