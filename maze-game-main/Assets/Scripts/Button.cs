using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   public GameObject target = null;

    void OnTriggerEnter (Collider user)
    {
        
        if(user.gameObject.name == "Player")
        {
            Debug.Log("Button pressed");
            target.SendMessage("TurnOn");
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    } 
}
