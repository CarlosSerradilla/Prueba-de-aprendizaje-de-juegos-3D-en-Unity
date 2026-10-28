using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedScript : MonoBehaviour
{
    public static bool isGrounded;

	private void OnTriggerEnter(Collider collision)
	{
		if (collision.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}
	
	private void OnTriggerExit(Collider collision)
	{
		if (collision.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}
}
