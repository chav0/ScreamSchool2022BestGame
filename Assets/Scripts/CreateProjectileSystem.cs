using UnityEngine;

public static class CreateProjectileSystem
{
	public static void Execute(Model model, View view)
	{
		if (model.Input.CreateProjectile)
		{
			model.CreateProjectile(model.Input.Angle, model.Input.ForceRatio);
			view.BunnyAnimator.SetTrigger("Attack");
			model.Player.PunchSound.Play();
		}
	}
}