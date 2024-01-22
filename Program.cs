int numberOfChicken = int.Parse(Console.ReadLine());
int numberOfFish = int.Parse(Console.ReadLine());   
int vegetarianMenu = int.Parse(Console.ReadLine());

double priceChickenMenu = numberOfChicken * 10.35;
double priceFishMenu = numberOfFish * 12.40;
double priceVegetarianMenu = vegetarianMenu * 8.15;

double totalCostMenus = priceChickenMenu + priceFishMenu + priceVegetarianMenu;
double priceForDesert = 0.2 * totalCostMenus;
double deliveryPrice = 2.50;

double totalOrderPrice = totalCostMenus + priceForDesert + deliveryPrice;

Console.WriteLine(totalOrderPrice);
