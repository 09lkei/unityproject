using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardscript : MonoBehaviour
{
	[SerializeField] private Attack attackScript;




	public void interact(int type)
	{
		switch (type)
		{
			case 0:
				Card1();
				break;

			case 1:
				Card2();
				break;

			case 2:
				attackScript.heal();
				break;
			default:
			break;
		}
	}

	public void Card1()
	{
		if (attackScript.canPunch)
		{
			attackScript.punch();
		}
	}

	public void Card2()
	{
		if (attackScript.canShoot)
		{
			attackScript.shoot();
		}
	}


}