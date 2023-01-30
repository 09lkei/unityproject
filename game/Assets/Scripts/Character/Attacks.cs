using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{

    public Projectile ProjectilePrefab;
    public Transform LaunchOffset;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 10, 0));

            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);

        }
    }
}
