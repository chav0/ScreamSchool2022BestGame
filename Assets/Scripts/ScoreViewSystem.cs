public static class ScoreViewSystem
{
	public static void Execute(Model model, View view)
	{
		view.GameUI.CurrentScore.text = model.CurrentScore.ToString();
		view.GameUI.Ammo.text = model.CurrentAmmoAmount.ToString(); 
	}
}
