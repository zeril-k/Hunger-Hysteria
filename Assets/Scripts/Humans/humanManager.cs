using UnityEngine;
using UnityEngine.UI;

public class humanManager : MonoBehaviour
{
    public int pointsCount;
    public Text pointsText;

    void Update()
    {
        pointsText.text = pointsCount.ToString();
    }
}
