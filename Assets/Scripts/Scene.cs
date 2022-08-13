using UnityEngine;

public class Scene : MonoBehaviour
{
    public GameObject scene;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 1);
    }

    
    void CreateObjects()
    {
        Instantiate(scene, new Vector3(6.83f, 2.41f, 0), Quaternion.identity);
    }
}
