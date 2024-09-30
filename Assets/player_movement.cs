using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isWounded = true;
        bool isBruised = false;

        if (isWounded && isBruised)
        {
            Debug.Log("dead");

        }
        else if (isWounded && !isBruised)
        {
            Debug.Log("ouch");
        }


        string animal = "Human";
        if (animal == "Human")
        {
            Debug.Log("teehee");
        }


        for (int i = 1; i <= 5; i++)
        {
            Debug.Log("loop" + i);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
