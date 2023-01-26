using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDamage : MonoBehaviour
{
    float amount = 5f;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Player>().TakeDamage(amount);


    }
}
