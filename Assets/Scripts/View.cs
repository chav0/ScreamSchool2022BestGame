using UnityEngine;
public class View
{
	public GameUI GameUI;
	public Animator BunnyAnimator;

	public View(GameUI gameUI, Animator bunnyAnimator, Model model)
	{
		GameUI = gameUI;
		BunnyAnimator = bunnyAnimator; 
		GameUI.Controller.Init(model);
	}
}
