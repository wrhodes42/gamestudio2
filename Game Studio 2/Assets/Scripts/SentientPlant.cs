using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SentientPlant : Tile
{
    public Flowchart flowchart;

    public override void OnTileEnter()
    {
        player.timer.AddTime(1); // talking to plants takes time i guess
        flowchart.ExecuteBlock("PlantTalk");
    }

    public override void OnTileExit(){
        
    }
}
