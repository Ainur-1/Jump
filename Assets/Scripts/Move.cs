using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.13f;
    }

    void FixedUpdate()
    {
         transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
    }
}
