using UnityEngine;

public static class CreateProjectileSystem
{
	public static void Execute(Model model)
	{
		if (model.Input.CreateProjectile)
		{
			model.CreateProjectile(model.Input.Angle, model.Input.ForceRatio);
		}
	}
}