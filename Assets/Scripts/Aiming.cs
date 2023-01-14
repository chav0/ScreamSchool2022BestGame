using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
	private float g = 9.8f; 
	
	public GameObject Point;

	private List<GameObject> _spawnedPoints = new List<GameObject>(); 

	public void Draw(bool isAiming, Vector3 startPosition, float xAngle, float yAngle, float force)
	{
		gameObject.SetActive(isAiming);

		if (!isAiming)
			return;
		
		if (_spawnedPoints.Count == 0)
		{
			for (int i = 0; i < 20; i++)
			{
				_spawnedPoints.Add(Instantiate(Point, transform));
			}
		}
		
		transform.localRotation = Quaternion.Euler(0f, xAngle, 0f);

		var h = startPosition.y; 
		var ux = force * Mathf.Cos(yAngle); 
		var uy = force * Mathf.Sin(yAngle); 
		var tMax = (uy + Mathf.Sqrt(uy * uy + 2 * g * h)) / g;

		for (int i = 0; i < 20; i++)
		{
			var t = i * tMax / 20;
			var x = t * ux; 
			var y = h + t * uy - g * t * t / 2;
			var point = _spawnedPoints[i];
			point.transform.localPosition = new Vector3(x, y, 0f); 
		}
	}
}
