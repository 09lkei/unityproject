using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardscript : MonoBehaviour
{
	[SerializeField] private Attack player;
	public void punch()
	{
		player.attack();
	}
}
