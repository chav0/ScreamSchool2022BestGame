public class View
{
	public GameUI GameUI;

	public View(GameUI gameUI, Model model)
	{
		GameUI = gameUI; 
		GameUI.Controller.Init(model);
	}
}
