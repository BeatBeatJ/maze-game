using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public CharacterController controller;
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            controller.Move(new Vector3(44.17f, player.transform.position.y, player.transform.position.z));
        }

    }

}
