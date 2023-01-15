using UnityEngine;
public static class AimingViewSystem
{
	private static float previousAngle; 
	
	public static void Execute(Model model, View view)
	{
		model.Player.Aiming.SetActive(model.Input.IsAiming);
		var angle = Mathf.Lerp(previousAngle, model.Input.Angle, 0.0001f);
		model.Player.View.transform.rotation = Quaternion.Euler(0f, angle, 0f);
		previousAngle = model.Input.Angle; 
	}
}
