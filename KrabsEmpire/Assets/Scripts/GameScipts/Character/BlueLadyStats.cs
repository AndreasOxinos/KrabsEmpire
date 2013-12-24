using UnityEngine;
using System.Collections;

public class BlueLadyStats : MonoBehaviour
{

	public int speed = 2;



	public int GetSpeed()
	{
		return speed;
	}

	public int GetSpeed(int modifier)
	{
		return speed + modifier;
	}

}
