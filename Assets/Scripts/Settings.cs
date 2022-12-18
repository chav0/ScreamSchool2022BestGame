using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Settings")]
public class Settings : ScriptableObject
{
	[Range(0, 360)]public float angle; // угол броска 
	[Range(0, 500)] public float force; // сила броска
	public int ammoClipSize; // количество патронов

	public GameObject ProjectilePrefab; 
}
