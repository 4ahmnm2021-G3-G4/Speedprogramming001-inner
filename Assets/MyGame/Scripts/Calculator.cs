using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public int Number1;
    public int Number2;
    public Text Result;
    public InputField Input1;
    public InputField Input2;

    public void InputNumbers()
    {
        Number1 = int.Parse(Input1.text);
        Number2 = int.Parse(Input2.text);
    }

   public void Calculate()
    {
        var result = Number1 + Number2;
        Result.text = result.ToString();

    }
}
