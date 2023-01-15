using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Localization", menuName = "LocalizationMap")]
public class LocalizationMap : ScriptableObject
{
	public List<LocalizationEntity> Localizations; 
}

[Serializable]
public class LocalizationEntity
{
	public string Key;
	public List<LocalizationValue> Value; 
}

[Serializable]
public class LocalizationValue
{
	public Language Language; 
	public string Text; 
}

public enum Language
{
	Ru,
	Eng
}