Console.Write("Podaj imie: ");
string name = Console.ReadLine();
Console.Write("Podaj nazwisko: ");
string surename = Console.ReadLine();
Console.Write("Podaj wiek: ");
int age = Convert.ToInt32(Console.ReadLine());
string promoCardType;

DateTime localDate = DateTime.Now;

if(age > 17){
    promoCardType = "Promo card for adult: \n";
} else {
    promoCardType = "Promo card for youth: \n";
}

// Console.WriteLine(promoCardType + "name: " + name + "\n surename: " + surename + "\n age: " + age);
Console.WriteLine($"{promoCardType} name: {name} \n surename: {surename} \n age: {age} \nActual date is {localDate.ToShortDateString()}");
