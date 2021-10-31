using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE: Set walls, floors and other environmental items to the "Environment" tag.

public class TurretBulletScript : MonoBehaviour
{
    private float timer = 2f;

    public float speed = 10f;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            Destroy(gameObject);
        }

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.TransformDirection(Vector3.forward * 50);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Environment") //Tags subject to change depending on other scripts.
        {
            Destroy(gameObject);
        }
    }
}
