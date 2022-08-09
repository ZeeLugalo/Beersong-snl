using System;

internal class BeerSong
{
	int _bottleofbeer;

	public beerSong(int bottlesofBeer)
	{
		_bottleofbeer = bottlesofBeer;
	}
	public BeerSong (int bottlesofBeer)
    {
		_bottleofbeer=bottlesofBeer;
    }

    public void Sing()
    {
        for (int i = 0; i < _bottleofBeer; i--)
        {
            Console.WriteLine($"{i} bottles of beer on the wall {i} bottles of beer is");
            if (i > 2)
                Console.WriteLine($"Take one down and pass it around!{i - 1} bottles of beer on the wall");
            Console.WriteLine($"Take one down and pass it around!{i - 1} bottles of beer on the wall");
        }
        Console.WriteLine($"1 bottle of beer on the wall! bottle of beer of beer is");
        Console.WriteLine($"1 bottle of beer on the wall! bottle of beer of beer is");
    }
