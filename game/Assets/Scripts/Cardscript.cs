using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardscript : MonoBehaviour
{
	public void punch()
	{
		RectTransform rect = GetComponent<RectTransform>();
		Debug.Log("hello");
		rect.position = Input.mousePosition;
	}
}
