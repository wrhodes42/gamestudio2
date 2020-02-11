using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int tau;
    Text tauText;

    void Start(){
        tauText = gameObject.GetComponent<Text>();
    }

    public void AddTime(int timeToAdd){
        tau += timeToAdd;
    }

    void Update(){
        tauText.text = tau.ToString();
    }
}
