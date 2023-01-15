using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultPopup : MonoBehaviour
{
	public TMP_Text ResultText;
	public TMP_Text RestartText;
	public TMP_Text NextText;
	public Button Restart;
	public Button Next;

	public void Init(string restartText, string nextText, int currentLevelSceneId, int nextLevelSceneId)
	{
		RestartText.text = restartText;
		NextText.text = nextText; 
		
		Restart.onClick.AddListener(() => SceneManager.LoadScene(currentLevelSceneId));
		Next.onClick.AddListener(() => SceneManager.LoadScene(nextLevelSceneId));
	}
}
