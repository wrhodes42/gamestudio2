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

    public override void OnTileEnter()
{
        player.actions.AddAction("Extract Minerals", 3);
    }

    public override void OnTileExit()
    {
        player.actions.RemoveAction("Extract Minerals");
    }
}
