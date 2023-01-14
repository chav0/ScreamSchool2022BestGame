using UnityEngine;
public static class AimingViewSystem
{
	public static void Execute(Model model, View view)
	{
		view.Aiming.Draw(model.Input.IsAiming, 
			model.Player.transform.position + Vector3.up,
			model.Input.Angle, 
			model.GameSettings.angle,
			model.GameSettings.force * model.Input.ForceRatio);
	}
}
