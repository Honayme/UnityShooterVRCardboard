using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

	public float speed = 20.0f;
	private float elapsed; 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		elapsed += Time.fixedDeltaTime;
		transform.position += transform.forward * speed * Time.fixedDeltaTime;

		if (elapsed > 5)
		{
			GameObject.Destroy(gameObject);
		}
	}
}
