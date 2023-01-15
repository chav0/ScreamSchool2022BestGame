using UnityEngine;
public static class ResultSystem
{
	public static void Execute(Model model, View view, LocalizationManager localizationManager)
	{
		if (model.CurrentScore == model.Enemies.Count)
		{
			model.GameOver = true; 
			view.GameUI.ResultPopup.gameObject.SetActive(true);
			view.GameUI.ResultPopup.Next.gameObject.SetActive(true);
			view.GameUI.ResultPopup.ResultText.text = localizationManager.Locale("loc_victory"); 
			PlayerPrefs.SetInt("current_level", model.Level);
		} 
		else if (model.CurrentAmmoAmount == 0)
		{
			model.GameOver = true; 
			view.GameUI.ResultPopup.gameObject.SetActive(true);
			view.GameUI.ResultPopup.Next.gameObject.SetActive(false);
			view.GameUI.ResultPopup.ResultText.text = localizationManager.Locale("loc_defeat"); 
		}
	}
}
