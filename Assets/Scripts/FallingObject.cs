using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
	public GameObject landingEffect;
	
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Floor")
		{
			Destroy(gameObject, 1.5f);
			GameObject landing = Instantiate(landingEffect, transform.position, Quaternion.identity);
			landing.GetComponent<ParticleSystem>().Emit(30);
		}
		if (collision.collider.tag == "FallingObject")
		{
			Destroy(gameObject);
		}
		if (collision.collider.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
