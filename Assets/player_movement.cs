using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
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
            //prints loop # 1 through 5
            Debug.Log("loop" + i);


        }

    }*/

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void LetterGrade(float grade)
    {
        if (grade >= 0.9)
        {
            Debug.Log("A");
        }
        else if (grade >= 0.8)
        {
            Debug.Log("B");
        }
        else if(grade >= 0.7)
        {
            Debug.Log("C");
        }
        else if (grade >= 0.6)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }

    }

    /*List<int> CreateList()
    {

        // foreach loops
        // creating list storing int values
        List<int> numbers = new List<int>();

        // filling list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(5);

        // remove element
        numbers.Remove(20);

        // sort list in ascending order
        numbers.Sort();

        // compute total sum and then add that to the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        numbers.Add(sum);
        // return list
        return numbers;

    }*/

}



// classes

/*public class House
{
    public string name = "my house";

    public bool Renovate()
    {
        return true;
    }

    House myHouse = new House();

    bool success = myHouse.Renovate();

    string house_name = myHouse.name;
}*/

// WHY IS THIS NOT WORKING BREHHHH



