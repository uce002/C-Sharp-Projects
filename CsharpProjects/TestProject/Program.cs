// 1 DICE ROLL and using Math.max
/*using System.ComponentModel.DataAnnotations;

Random dice = new Random(); //new instance of a class (object). to access 
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);*/


// 2 DICE ROLL 3 dice using nested if statements and else if statements to calculate total, reward bonuses and log prizes based on score
/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

roll1 = 6;
roll2 = 6;
roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if(roll1 == roll2 || roll2 == roll3 || roll3 == roll1) {

    if((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;   
    }
}
    
if(total >= 16) {
    Console.WriteLine("You win a new car!");
} 
else if(total >= 10) {
    Console.WriteLine("You win a new laptop!");
} 
else if (total == 7) {
    Console.WriteLine("You win a trip for two!");
} 
else {
    Console.WriteLine("You win a kitten!");
}*/


// 3 RESUBSCRIPTION PROGRAM using random, else if statements and string interpolation for a fictitious business
/*Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} 
else if(daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day! \nRenew now and save {discountPercentage} %");
} 
else if(daysUntilExpiration <= 5) {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires within {daysUntilExpiration} days. \nRenew now and save {discountPercentage} %");
} 
else if(daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}*/


// 4 FRAUDULENT ORDER CHECKER using an array, intialising and retrieving and using Length
/*string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";*/
//fraudulentOrderIDs[3] = "D000";

/*string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/


// 5 INVENTORY SCAN PROJECT
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach(int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");