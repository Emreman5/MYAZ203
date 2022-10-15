// See https://aka.ms/new-console-template for more information

using Nesne_programlama_odev2;

var product1 = new Product()
{
  Id  = 1,
  Price = 1000,
  ProductName = "Tablet",
};
var product2 = new Product()
{
  Id  = 2,
  Price = 2000,
  ProductName = "Telefon",
};

var item1 = new CartItem()
{
  Id = 1,
  Product = product1,
  Quantity = 3
};
var item2 = new CartItem()
{
  Id = 2,
  Product = product2,
  Quantity = 4
};
var manager = new ShoppingCartManager();
manager.Add(item1);
manager.Add(item2);
manager.GetList();
manager.GetBalance();