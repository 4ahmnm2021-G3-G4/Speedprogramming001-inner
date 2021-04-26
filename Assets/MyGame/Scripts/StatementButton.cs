using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatementButton : MonoBehaviour
{
    GameObject Wahr;
  GameObject Falsch;
    bool aButton = true;

public void SwitchAnswer(){

if(aButton)
{
Wahr.text = "Antworten sind wahr.";
aButton = false;
}
else {
Falsch.text = "Antworten sind falsch.";
aButton = true;
}


}

}
