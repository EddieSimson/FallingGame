using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Player player;
    public Text score;

	private void Update()
	{
		score.text = Mathf.Round(player.health).ToString();
	}
}
