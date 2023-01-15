using TMPro;
using UnityEngine;

public class Bubble : MonoBehaviour
{
	public Animator Animator;
	public TMP_Text Text;

	public void Show(string text)
	{
		Text.text = text; 
		Animator.SetTrigger("Show");
	}
}
