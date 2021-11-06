using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
 
    void OnTriggerEnter (Collider user)
    {
        if(user.gameObject.name == "Player")
        {
            Player.transform.position = TeleportTo.transform.position;
        }
    }
}
