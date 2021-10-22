using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootie : MonoBehaviour
{
    public Rigidbody projectile;
    private Vector3 offset = new Vector3(0, 0, 2);

    private void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position + transform.rotation * offset, transform.rotation); //Had to multiply the offset by player's rotation before adding it to position value.
            clone.velocity = transform.TransformDirection(Vector3.forward * 50);
        }
    }
}
