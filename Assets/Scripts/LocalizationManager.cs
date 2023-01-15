using System;
public class LocalizationManager
{
	private readonly LocalizationMap _map;
	private Language _currentLanguage; 
	
	public LocalizationManager(LocalizationMap map, Settings settings)
	{
		_map = map;
		_currentLanguage = settings.Language; 
	}

	public string Locale(string key)
	{
		for (int i = 0; i < _map.Localizations.Count; i++)
		{
			var entity = _map.Localizations[i];
			if (entity.Key == key)
			{
				for (int j = 0; j < entity.Value.Count; j++)
				{
					var value = entity.Value[j];
					if (value.Language == _currentLanguage)
						return value.Text; 
				}
			}
		}
		
		return String.Empty;
	}
}
