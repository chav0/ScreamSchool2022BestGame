using UnityEngine;

public class BunnyMoving : MonoBehaviour
{
	public Animator BunnyAnimator;
	public float Speed;
	
	void Update()
	{
		var isMoving = false;
		
	    if (Input.GetKey(KeyCode.A))
	    {
		    transform.position += Vector3.left * Time.deltaTime * Speed;
		    isMoving = true; 
	    }

	    if (Input.GetKey(KeyCode.D))
	    {
		    transform.position += Vector3.right * Time.deltaTime * Speed;
		    isMoving = true; 
	    }
	    
	    BunnyAnimator.SetBool("IsMoving", isMoving);
    }
}
