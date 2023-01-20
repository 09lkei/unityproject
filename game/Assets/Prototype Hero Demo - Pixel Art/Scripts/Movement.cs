using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(0, 5);
        }
        if (Input.GetKeyDown("left"))
        {
            rb.velocity = new Vector2(-3, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            rb.velocity = new Vector2(3, 0);
        }
    }
}
