using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
	public Sprite original;
	public Sprite attack;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 0")){
			spriteRenderer.sprite = attack;
			Debug.Log("Hello");
		}
    }
}
