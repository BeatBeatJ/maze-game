using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    public Transform turret;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float rateOfFire = 1f;
    public Vector3 bulletOffset = new Vector3(0, 0, 2);

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            turret.LookAt(other.transform);

            if (rateOfFire <= 0)
            {
                GameObject clone;
                clone = Instantiate(bulletPrefab, transform.position + transform.rotation * bulletOffset, transform.rotation);
                rateOfFire = 1f;
            }
            else
            {
                rateOfFire = rateOfFire - Time.deltaTime;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            rateOfFire = 1f;
        }
    }
}
