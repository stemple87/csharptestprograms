using System;
using System.Collections.Generic;

class Animal
{
  public string Name;
  public string Breed;
  public string Speces;
  public int Age;
}

class AnimalShelter
{
  static void Main()
  {
    Animal whiskers = new Animal();
    whiskers.Name = "Whiskers";
    whiskers.Breed = "Main Coon";
    whiskers.Speces = "Cat";
    whiskers.Age = 5;

    Animal spot = new Animal();
    spot.Name = "Spot";
    spot.Breed = "Mut";
    spot.Speces = "Dog";
    spot.Age = 3;

    Animal ruffles = new Animal();
    ruffles.Name = "ruffles";
    ruffles.Breed = "Golden Retriever";
    ruffles.Speces = "dog";
    ruffles.Age = 7;

    Animal frisky = new Animal();
    frisky.Name = "Frisky";
    frisky.Breed = "Russian Blue";
    frisky.Speces = "Cat";
    frisky.Age = 11;

    List<Animal> Animals = new List<Animal>() { whiskers, spot, ruffles, frisky };
    foreach(Animal fluffers in Animals)
    {
      Console.WriteLine(fluffers.Name);
    }


    Console.WriteLine("Input your new animal's maximum age");
    string inputAge = Console.ReadLine();
    int numberAge = int.Parse(inputAge);

    List<Animal> animalsMatchingSearch = new List<Animal>() {};
    foreach(Animal fluffers in Animals)
    {
      if(fluffers.Age <= numberAge) {
        animalsMatchingSearch.Add(fluffers);
      }

    }
    foreach(Animal fluffers in animalsMatchingSearch)
    {
      Console.WriteLine(fluffers.Breed);
    }
  }
}
