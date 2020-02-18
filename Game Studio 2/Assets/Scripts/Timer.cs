using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Timer : MonoBehaviour
{
    public int tau;
    public Flowchart flowchart;
    public string tauVarKey;
    Text tauText;
    public int TAU_INTERVAL = 10;
    public Player Player;

    void Start(){
        tauText = gameObject.GetComponent<Text>();
    }

    public void AddTime(int timeToAdd){
        tau += timeToAdd;
        flowchart.SetIntegerVariable(tauVarKey, tau);

        float currentInterval = tau / TAU_INTERVAL;
        // return to ship
        if (flowchart.GetIntegerVariable("numCheckins") < currentInterval)
        {
            flowchart.ExecuteBlock("CheckIn");

            // 
            Debug.Log("post flowchart.ExecuteBlock(CheckIn); ");
            Player.ReturnToShip();
        }
    }

    void Update(){
        tauText.text = tau.ToString();
    }
}
