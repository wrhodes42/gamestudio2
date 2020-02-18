using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BlueFlower : Tile
{
    public Flowchart flowchart;

    public override void OnTileEnter()
    {
        flowchart.ExecuteBlock("PlantTalk");
    }


    public override void OnTileExit()
    {
    }
}
