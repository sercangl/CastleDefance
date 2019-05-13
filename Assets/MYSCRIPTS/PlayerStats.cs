using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public static int Money;
    public int startingMoney = 150;
    public static int Lives;
    public int startingLives;
    

	// Use this for initialization
	void Start ()
    {
        Money = startingMoney;
        Lives = startingLives;
	}
	
	// Update is called once per frame
	void Update ()
    {
       
    }
}
