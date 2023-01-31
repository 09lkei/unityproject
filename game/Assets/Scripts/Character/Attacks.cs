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
            Instantiate(ProjectilePrefab, LaunchOffset.position, new Quaternion(0,0,0,transform.localScale.x));

        }
    }
}
