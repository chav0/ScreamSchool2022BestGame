using UnityEngine;

public class Enemy : MonoBehaviour
{
	public Model Model; 
	
	public void Init(Model model)
	{
		Model = model; 
	}
	
	private void OnCollisionEnter(Collision collision)
	{
		// Увеличиваем скор на 1
		Model.CurrentScore += 1;
		
		// Удаляем коллайдер с врага 
		var enemyCollider = GetComponent<Collider>(); 
		Destroy(enemyCollider);
		gameObject.SetActive(false);
		
		Debug.Log("On collision enter");
	}
}
