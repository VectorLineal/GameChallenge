using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCards : MonoBehaviour
{
    public Image card1, card2, card3;
    public Testing algo;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            if (card1.enabled)
            {
                card1.enabled = false;
            }
            else if (card2.enabled)
            {
                card2.enabled = false;
            }
            else
            {
                card3.enabled = false;
            }
            if (algo.lives>0) {
                algo.lives--;
            }
        }
    }
}
