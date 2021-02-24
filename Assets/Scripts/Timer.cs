using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text score;
	public void Update()
	{
		score.text = "You Survived For " + Mathf.Round(Player.timer).ToString() + "s";
	}
}
