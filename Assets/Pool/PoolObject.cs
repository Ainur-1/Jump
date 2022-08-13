using UnityEngine;

public class PoolObject : MonoBehaviour
{
    public void Disable()
    {
        gameObject.SetActive(false);
    }
}
