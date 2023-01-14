using UnityEngine;
public class View
{
	public GameUI GameUI;
	public Animator BunnyAnimator;
	public Aiming Aiming; 
	
	public View(GameUI gameUI, Animator bunnyAnimator, Model model, Aiming aiming)
	{
		GameUI = gameUI;
		BunnyAnimator = bunnyAnimator; 
		Aiming = aiming; 
		GameUI.Controller.Init(model);
	}
}
