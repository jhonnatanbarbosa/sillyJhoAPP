using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject sandbox; // the sandbox menu
    public GameObject sandboxButton; // the sandbox button
    public GameObject back; // the back button

    // when the sandbox button is pressed
    public void sandboxMode(){ 
        sandbox.SetActive(true); 
        sandboxButton.SetActive(false);
        back.SetActive(true);
    }

    // when the back button is pressed
    public void exitSandbox(){
        sandbox.SetActive(false);
        sandboxButton.SetActive(true);
        back.SetActive(false);
    }


}
