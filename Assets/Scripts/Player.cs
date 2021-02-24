using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody rb;
	public float speed;
	private float MoveInputX;
	private float MoveInputZ;
	public float turnSmoothTime = 0.1f;
	float turnSmoothVelocity;
	public float health;
	public static float timer;
	public float healthLoss;
	public float healthGain;
	private void FixedUpdate()
	{
		MoveInputX = Input.GetAxisRaw("Horizontal");
		MoveInputZ = Input.GetAxisRaw("Vertical");
		rb.velocity = new Vector3(MoveInputX * speed, rb.velocity.y, MoveInputZ * speed);

		Vector3 direction = new Vector3(MoveInputX, 0f, MoveInputZ).normalized;
		float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg; 
		float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
		transform.rotation = Quaternion.Euler(0f, angle, 0f);
	}
	public void loseHealth()
	{
		health -= healthLoss;
	}
	private void Update()
	{
		loseHealth();
		if (health <= 0 || transform.position.y <= -2)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
		if (health >= 100)
		{
			health = 100;
		}
		timer += Time.deltaTime;
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "FallingObject")
		{
			health += healthGain;
		}
	}
}
