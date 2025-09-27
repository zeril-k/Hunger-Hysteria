using UnityEngine;

public class chemicalManager : MonoBehaviour
{
    public int chemicalCount;

    public GameObject door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chemicalCount == 1)
        {
            Destroy(door);
        }
    }
}
