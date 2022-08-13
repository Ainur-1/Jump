using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
