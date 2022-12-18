public class Animal
{
	public int Health;
	public bool IsAlive;
	public float Weight;
	public string Name;

	public Animal(int health, string animalName)
	{
		Health = health;
		Name = animalName;
		IsAlive = true; 
	}

	public void Eat(Animal animal)
	{
		if (!animal.IsAlive)
			return;
		else
		{
			Weight = Weight + 1;
			animal.Health = animal.Health - 1;
		}
	}

	public void Damage(int damage)
	{
		Health = Health - damage; 
	}
}