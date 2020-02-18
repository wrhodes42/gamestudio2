using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerField : Tile // this is just an example of a specific tile script
{
    public override void OnTileEnter()
    {
        player.actions.AddAction("Pick Flower", 3);
    }

    public override void OnTileExit()
    {
        player.actions.RemoveAction("Pick Flower");
    }

    public void Start()
    {
        // for some reason, these sprites appear really small compared to blank green tiles
        //this.transform.localScale = Vector3.one * 3.5f;
        //fixed
    }
}
