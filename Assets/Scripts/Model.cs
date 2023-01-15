using System.Collections.Generic;
using UnityEngine;

public class Model
{
	public Settings GameSettings; 
	public int CurrentScore;
	public int CurrentAmmoAmount;
	public PlayerInput Input;

	public Player Player;
	public List<Enemy> Enemies;
	public List<Projectile> Projectiles = new List<Projectile>();

	public bool GameOver;
	public int Level; 

	public Model(Settings settings, Player player, List<Enemy> enemies, int level)
	{
		CurrentScore = 0;
		CurrentAmmoAmount = settings.ammoClipSize;
		GameSettings = settings;
		Player = player;
		Enemies = enemies;
		Input = new PlayerInput();
		Level = level; 
	}

	public void CreateProjectile(float angle, float forceRatio)
	{
		var projectileObject = Object.Instantiate(GameSettings.ProjectilePrefab, Player.transform.position + Vector3.up, Quaternion.identity);
		var projectile = projectileObject.GetComponent<Projectile>(); 
		Projectiles.Add(projectile);

		var vector = Quaternion.Euler( -GameSettings.angle, angle, 0f) * Player.transform.forward;
		var force = GameSettings.force * forceRatio * vector;
		projectile.Rigidbody.AddForce(force, ForceMode.Impulse);
		
		CurrentAmmoAmount -= 1; 
	}

	public void Clear()
	{
		CurrentScore = 0;
		CurrentAmmoAmount = GameSettings.ammoClipSize;

		foreach (var projectile in Projectiles)
		{
			Object.Destroy(projectile.gameObject);
		}
	}
}