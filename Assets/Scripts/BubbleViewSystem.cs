public static class BubbleViewSystem
{
	private static int cachedScore; 
	private static int cachedCurrentAmmoAmount; 
	
	public static void Execute(Model model, View view, LocalizationManager localizationManager)
	{
		if (cachedScore < model.CurrentScore)
		{
			cachedScore = model.CurrentScore; 
			view.GameUI.Bubble.Show(localizationManager.Locale("loc_good_job"));
		}

		if (cachedCurrentAmmoAmount < model.CurrentAmmoAmount && model.CurrentAmmoAmount == 5)
		{
			cachedCurrentAmmoAmount = model.CurrentAmmoAmount; 
			view.GameUI.Bubble.Show(localizationManager.Locale("loc_try_harder"));
		}
	}
}
