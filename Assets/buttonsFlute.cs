using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsFlute : MonoBehaviour
{
    public GameObject hole1;
    public GameObject hole2;
    public GameObject hole3;
    public GameObject hole4;
    public GameObject hole5;
    public GameObject hole6;
    public GameObject hole7;

    public void clearFlute(){
        hole1.SetActive(false);
        hole2.SetActive(false);
        hole3.SetActive(false);
        hole4.SetActive(false);
        hole5.SetActive(false);
        hole6.SetActive(false);
        hole7.SetActive(false);
    }
    public void aNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
    }

    public void bNote(){
        clearFlute();
        hole1.SetActive(true);
    }

    public void cNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
        hole5.SetActive(true);
        hole6.SetActive(true);
        hole7.SetActive(true);
    }

    public void dNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
        hole5.SetActive(true);
        hole6.SetActive(true);
    }

    public void eNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
        hole5.SetActive(true);
    }

    public void fNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
    }

    public void gNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
    }

}
