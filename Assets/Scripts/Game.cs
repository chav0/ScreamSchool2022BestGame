using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	public GameUI GameUI; 
	public Settings GameSettings;
	public Player GamePlayer;
	public Animator BunnyAnimator;
	public List<Enemy> Enemies; 

	public Model GameModel;
	public View GameView; 

	public void OnEnable()
	{
		GameModel = new Model(GameSettings, GamePlayer);
		GameView = new View(GameUI, BunnyAnimator, GameModel);

		for (int i = 0; i < Enemies.Count; i++)
		{
			Enemies[i].Init(GameModel);
		}
	}
	
	void Update()
    {
	    CreateProjectileSystem.Execute(GameModel, GameView);
	    ClearInputSystem.Execute(GameModel);
	    ScoreViewSystem.Execute(GameModel, GameView);
    }
}
