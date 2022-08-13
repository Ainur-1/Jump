using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Pool))]

public class PlatformSpawner : MonoBehaviour
{
    public int renderingDistance = 10;
   
    private Pool platformsPool;

    void Start()
    {
        platformsPool = GetComponent<Pool>();

        SpawnPlatforms();
    }

    private void SpawnPlatforms()
    {
        for (int i = -renderingDistance; i <= renderingDistance; i++)
        {
            platformsPool.GetFreeElement(new Vector3(i * 2.0f, -5, 0), Quaternion.identity);
        }
    }
}
