using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectSpawner : MonoBehaviour
{
	public GameObject FallingObject;

	private float TimeBtwSpawn;
	public float StartTimeBtwSpawn;

	private void Update()
	{
		if (TimeBtwSpawn <= 0)
		{
			Instantiate(FallingObject, new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f)), Quaternion.identity);
			TimeBtwSpawn = StartTimeBtwSpawn;
		}
		else
		{
			TimeBtwSpawn -= Time.deltaTime;
		}
	}
}
