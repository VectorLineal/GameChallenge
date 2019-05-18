using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleEnergy : MonoBehaviour
{
    public Image batery;
    public Sprite skin4, skin3, skin2, skin1, skin0;
    public Testing algo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (algo.energy)
        {
            case 4:
                batery.sprite = skin4;
                break;
            case 3:
                batery.sprite = skin3;
                break;
            case 2:
                batery.sprite = skin2;
                break;
            case 1:
                batery.sprite = skin1;
                break;
            case 0:
                batery.sprite = skin0;
                break;
            default:
                batery.sprite = skin0;
                break;
        }

        if (Input.GetKeyDown("e"))
        {
            algo.energy--;
        }
    }
}
