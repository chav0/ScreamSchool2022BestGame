using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour
{
	public Settings Settings;

	private void OnEnable()
	{
		var currentLevel = PlayerPrefs.GetInt("current_level");
		for (int i = 0; i < Settings.Levels.Count; i++)
		{
			var level = Settings.Levels[i];
			if (level.Num == currentLevel)
			{
				var nextLevelIndex = i + 1;
				if (nextLevelIndex >= Settings.Levels.Count)
				{
					SceneManager.LoadScene(level.SceneId); 
					return;
				}
				else
				{
					SceneManager.LoadScene(Settings.Levels[nextLevelIndex].SceneId); 
					return;
				}
			}
		}
		
		SceneManager.LoadScene(Settings.Levels[0].SceneId); 
	}
}
