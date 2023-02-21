using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardscript : MonoBehaviour
{
	[SerializeField] private Attack player;
	public void interact(int type)
	{
		switch (type)
		{
			case 0:
				player.punch();
				break;
			case 1:
				player.shoot();
				break;
			case 2:
				player.heal();
				break;
			default:
			break;
		}
	}
}