using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Settings")]
public class Settings : ScriptableObject
{
	public Language Language; 
	[Range(0, 360)]public float angle; // угол броска 
	[Range(0, 500)] public float force; // сила броска
	public int ammoClipSize; // количество патронов

	public GameObject ProjectilePrefab;

	public List<Level> Levels; 
}

[Serializable]
public class Level
{
	public int Num;
	public int SceneId; 
}
