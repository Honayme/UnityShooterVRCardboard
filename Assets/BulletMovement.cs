using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

	public float speed = 20.0f; 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.position += transform.forward * speed * Time.fixedDeltaTime; 
	}
}
