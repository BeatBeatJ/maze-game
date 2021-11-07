using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    private int ButtonsPressed = 0;
    public GameObject target = null;
    public int TriggersToSolve = 3;
    
    void TurnOn()
    {
        ButtonsPressed = ButtonsPressed + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonsPressed == TriggersToSolve)
        {
            target.SendMessage("TurnOn");
        }
    }
}
