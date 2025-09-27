using UnityEngine;
using UnityEngine.UI;

public class humanManager : MonoBehaviour
{
    public int pointsCount;
    public Text pointsText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = pointsCount.ToString();
    }
}
