using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsFlute : MonoBehaviour
{

    //intializes all holes
    public GameObject hole1;
    public GameObject hole2;
    public GameObject hole3;
    public GameObject hole4;
    public GameObject hole5;
    public GameObject hole6;
    public GameObject hole7;

    //clears all holes
    public void clearFlute(){ 
        hole1.SetActive(false);
        hole2.SetActive(false);
        hole3.SetActive(false);
        hole4.SetActive(false);
        hole5.SetActive(false);
        hole6.SetActive(false);
        hole7.SetActive(false);
    }

    //activates holes for a note
    public void aNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
    }

    //activates holes for a note
    public void bNote(){
        clearFlute();
        hole1.SetActive(true);
    }

    //activates holes for a note
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

    //activates holes for a note
    public void dNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
        hole5.SetActive(true);
        hole6.SetActive(true);
    }

    //activates holes for a note
    public void eNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
        hole5.SetActive(true);
    }

    //activates holes for a note
    public void fNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
        hole4.SetActive(true);
    }

    //activates holes for a note
    public void gNote(){
        clearFlute();
        hole1.SetActive(true);
        hole2.SetActive(true);
        hole3.SetActive(true);
    }

}
