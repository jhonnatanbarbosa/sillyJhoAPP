using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject sandbox;
    public GameObject sandboxButton;
    public GameObject back;

    public void sandboxMode(){
        sandbox.SetActive(true);
        sandboxButton.SetActive(false);
        back.SetActive(true);
    }

    public void exitSandbox(){
        sandbox.SetActive(false);
        sandboxButton.SetActive(true);
        back.SetActive(false);
    }


}
