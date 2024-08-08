using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIllusionButton : MonoBehaviour
{
    public GameObject smallBalls;
    public GameObject bigBalls;
    bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonPressed()
    {
        if (!isPressed)
        {
            
            smallBalls.SetActive(false);
            bigBalls.SetActive(false);
            isPressed = true;
        }
        else
        {
            
            smallBalls.SetActive(true);
            bigBalls.SetActive(true);
            isPressed = false;
        }

    }
}
