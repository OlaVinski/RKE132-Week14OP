Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

//loome muutuja vahemälus, see muutus on juba keerulisem kastike
//string tüüpi nime jaoks ja int tüüpi heaolu taseme jaoks//
Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");


class Dog
{
    private string _name; //private=väljaspool seda klassi pole nime võimalik kätte saada ja muuta
    //field on kaitstud
    private int _levelOfHappiness;

    //constructor
    public Dog(string name) //name -lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter võimaldab private anmdeid kuvada
    public string Name
    {
        get { return _name; } 
    }   

    public int LevelOfHappiness //SUURE TÄHEGA - rõhutas mitu korda, et peab olema siin suur esimene täht
    {
        get { return _levelOfHappiness; }
    }

    //setter võimaldab luua meetodi nime muutmiseks
    public void Rename(string newName)
    { 
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }

}

