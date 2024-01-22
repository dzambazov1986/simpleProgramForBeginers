int basketballTrainingFee = int.Parse(Console.ReadLine());

double basketballSneakers = (basketballTrainingFee - 0.4 * basketballTrainingFee);
double basketballTeam = (basketballSneakers - 0.20 * basketballSneakers);
double priceForBasketball = basketballTeam * 0.25;
double basketballAcesoaries = 0.2 * priceForBasketball;

double totalPriceForEquipment = basketballTrainingFee + basketballSneakers + basketballTeam + priceForBasketball + basketballAcesoaries;

Console.WriteLine(totalPriceForEquipment);
