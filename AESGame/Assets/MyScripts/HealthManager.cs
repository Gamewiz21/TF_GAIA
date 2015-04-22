using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public int Lives;// life class
    public int health;// Health class
    protected virtual void Start()
    {
        health = 100;// intial health value at start of game for both player and enemy

    }


    protected virtual void Update()
    {

    }
    public void setHealth(int number)
    {
        health = number;
    }
    // obtains the value of health and returns it to the HealthBar class
    public float getHealth()
    {
        return health;
    }

	public void setLife(int number)
	{
		Lives = number;
	}
	// obtains the value of health and returns it to the HealthBar class
	public float getLife()
	{
		return Lives;
	}
}
