using System.Collections.Generic;
using UnityEngine;
public class Main : MonoBehaviour
{
	void OnEnable()
	{
		Animal dog = new Animal(10, "Dog");
		Animal rat = new Animal(1, "Rat"); 
		Animal cat = new Animal(5, "Cat"); 
		
		dog.Eat(rat);

		List<Animal> animals = new List<Animal>(); 
		
		animals.Add(dog);
		animals.Add(rat);
		animals.Add(cat);

		for (int i = 0; i < animals.Count; i++)
		{
			Animal animal = animals[i]; 
			Debug.Log(animal.Name);
		}
	}
}
