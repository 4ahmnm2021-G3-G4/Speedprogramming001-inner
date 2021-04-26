using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddNumbers : MonoBehaviour
{


    public void Calculate(int a, int b)
    {
        if (a + b == 9)
            Debug.Log("answer is 9");

        else
        {
         Debug.Log("answer is not 9");
    }

   }

}
