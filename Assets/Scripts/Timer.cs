using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text score;
	public void Update()
	{
		score.text = Mathf.Round(Player.timer).ToString() + "s";
	}
}
