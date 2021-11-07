using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouch: MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.transform.tag == "Player")
        {
            GameObject respawn = GameObject.FindWithTag("Respawn");
            other.transform.position = respawn.transform.position;
        }
    }
}
