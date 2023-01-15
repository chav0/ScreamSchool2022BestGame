using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	public int Level; 
	public GameUI GameUI; 
	public Settings GameSettings;
	public Player GamePlayer;
	public List<Enemy> Enemies;
	public LocalizationMap LocalizationMap; 
	public LocalizationManager LocalizationManager; 

	public Model GameModel;
	public View GameView; 

	public void OnEnable()
	{
		GameModel = new Model(GameSettings, GamePlayer, Enemies, Level);
		GameView = new View(GameUI, GamePlayer.BunnyAnimator, GameModel);
		LocalizationManager = new LocalizationManager(LocalizationMap, GameSettings);

		var currentLevel = Level;
		var currentLevelSceneId = 0;
		var nextLevelSceneId = 0; 
		for (int i = 0; i < GameSettings.Levels.Count; i++)
		{
			var level = GameSettings.Levels[i];
			if (level.Num == currentLevel)
			{
				currentLevelSceneId = level.SceneId; 

				var nextLevelIndex = i + 1;
				if (nextLevelIndex < GameSettings.Levels.Count)
					nextLevelSceneId = GameSettings.Levels[nextLevelIndex].SceneId; 
				else 
					nextLevelSceneId = level.SceneId; 
			}
		}

		GameView.GameUI.ResultPopup.Init(LocalizationManager.Locale("loc_restart"), 
			LocalizationManager.Locale("loc_next"), currentLevelSceneId, nextLevelSceneId);

		for (int i = 0; i < Enemies.Count; i++)
		{
			Enemies[i].Init(GameModel);
		}
	}
	
	void Update()
	{
		if (GameModel.GameOver)
			return;
		
	    CreateProjectileSystem.Execute(GameModel, GameView);
	    ClearInputSystem.Execute(GameModel);
	    ScoreViewSystem.Execute(GameModel, GameView);
	    AimingViewSystem.Execute(GameModel, GameView);
	    BubbleViewSystem.Execute(GameModel, GameView, LocalizationManager);
	    ResultSystem.Execute(GameModel, GameView, LocalizationManager);
	}
}
