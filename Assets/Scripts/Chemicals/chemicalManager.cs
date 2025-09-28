using UnityEngine;

public class chemicalManager : MonoBehaviour
{
    public int chemicalCount;

    public GameObject door;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;

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

        if (chemicalCount == 2)
        {
            Destroy(door2);
        }

        if (chemicalCount == 3)
        {
            Destroy(door3);
        }

        if (chemicalCount == 4)
        {
            Destroy(door4);
        }
    }
}
