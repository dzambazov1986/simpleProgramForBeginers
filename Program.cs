int requiredNylon = int.Parse(Console.ReadLine());
int requiredPaint = int.Parse(Console.ReadLine());
int quantityThiner = int.Parse(Console.ReadLine());
int hoursNeedCraftsmen = int.Parse(Console.ReadLine());

double nylon = (requiredNylon + 2) * 1.50;
double paint = (requiredPaint + 0.1 * requiredPaint) * 14.50;
int thiner = quantityThiner * 5;
double bags = 0.40;

double totalAmountMaterials = nylon + paint + thiner + bags;
double amountCraftsmen = (totalAmountMaterials * 0.3 ) * hoursNeedCraftsmen;
double totalAmount = (totalAmountMaterials + amountCraftsmen);

Console.WriteLine(totalAmount);