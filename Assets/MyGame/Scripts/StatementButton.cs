using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatementButton : MonoBehaviour
{
 
   bool aButton = true;

public void SwitchAnswer(){

if(aButton)
{
GetComponent<Text>().text = "wahr.";
aButton = false;
}
else {
GetComponent<Text>().text = "falsch.";
aButton = true;
}


}

}
