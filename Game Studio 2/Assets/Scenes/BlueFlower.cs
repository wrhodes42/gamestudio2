using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BlueFlower : Tile
{

    public override void OnTileEnter()
    {
        player.actions.AddAction("Pick Flower", 1);
    }


    public override void OnTileExit()
    {
        player.actions.RemoveAction("Pick Flower");
    }
}
