using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Fungus;

public class MineralDeposit : Tile
{

    public Flowchart flowchart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void OnTileEnter(){
        flowchart.ExecuteBlock("MineralDeposit");
    }
}
