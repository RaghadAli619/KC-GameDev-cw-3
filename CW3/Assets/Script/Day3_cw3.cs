using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3_cw3 : MonoBehaviour
{
    // Hero information
    string heroName = "Jay";
    int heroPower = 7;

    // Villain information
    string villainName = "William";
    int villainPower = 9;

    // Speed
    float playerspeed = 2.5f;

    // Speed
    int speed1 = 20;
    int speed2 = 26;

    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villainPower)
        {
            print("Jay is stronger than William");
        }

        else if (heroPower == villainPower)
        {
            print("Jay is as strong as William");
        }

        else
        {
            print("William is stronger than Jay");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setspeed(float newspeed)
    {
        print(playerspeed);
        playerspeed = newspeed;
        print(playerspeed);
    }

    void comparespeed()
    {
        if (speed1 > speed2)
        {
            print("Speed1 is faster than speed2");
        }

        else if (speed1 == speed2)
        {
            print("Speed1 is as fast as speed2");
        }

        else
        {
            print("Speed2 is faster than speed1");
        }
    }
}
