using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
	public void restart()
	{
		SceneManager.LoadScene("MainGame");
		Player.timer = 0;
	}
}
