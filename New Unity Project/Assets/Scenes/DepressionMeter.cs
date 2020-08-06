using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DepressionMeter : MonoBehaviour
{
    public int depression_plus_correctoffset;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if(depression_plus_correctoffset <= 0)
        {
            SceneManager.LoadScene("LoseScene");
            print("You Lose");
        }
    }

    void OnMouseDown()
    {
        // if (!GameObject.FindWithTag("correctanswer"))
        depression_plus_correctoffset--;
            print(depression_plus_correctoffset + "depressed");

     //   this.GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 0, (255 - (255/10 * depression)));
    }
}
