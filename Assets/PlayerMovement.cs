using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform transform;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveX(float x)
    {
        transform.position = new Vector3(x, 0, 0);
    }

    public void moveY(float z)
    {
        transform.position = new Vector3(0, 0, z);
    }
}
