using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settings; // the sandbox menu
    public GameObject settingsButton; // the sandbox button
    public GameObject back; // the back button

    // when the sandbox button is pressed
    public void settingsMode(){ 
        settings.SetActive(true); 
        settingsButton.SetActive(false);
        back.SetActive(true);
    }

    // when the back button is pressed
    public void exitSettings(){
        settings.SetActive(false);
        settingsButton.SetActive(true);
        back.SetActive(false);
    }


}

