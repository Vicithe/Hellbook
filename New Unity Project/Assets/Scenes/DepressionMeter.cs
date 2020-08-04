using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepressionMeter : MonoBehaviour
{
    private int depression;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/Blackscreen").GetComponent<Image>().color = new Color(0, 0, 0, 0);
        depression = 0;
    }

    void OnMouseDown()
    {
        if (!GameObject.FindWithTag("correctanswer"))
        {
            depression++;
        }

        GameObject.Find("Canvas/BlackScreen").GetComponent<Image>().color = new Color(0, 0, 0, (255 / 10 * depression));
    }
}
