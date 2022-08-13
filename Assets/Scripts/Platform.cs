using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PoolObject))]

public class Platform : MonoBehaviour
{
    public Transform renderPoint;
    private PoolObject _poolObject;

    // Start is called before the first frame update
    void Start()
    {
        _poolObject = GetComponent<PoolObject>();
    }

    private void Update()
    {
        if (transform.position.x < renderPoint.position.x)
        {
            DestroyPlatform();
        }
    }

    private void DestroyPlatform()
    {

    }
}
