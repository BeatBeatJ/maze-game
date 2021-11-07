using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotReset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject respawn = GameObject.FindWithTag("Respawn");
            other.transform.position = respawn.transform.position;
        }
    }
}
