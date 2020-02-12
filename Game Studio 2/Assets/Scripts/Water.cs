using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Tile // this is just an example of a specific tile script
{
    public override void OnTileEnter()
    {
        player.timer.AddTime(1); // swimming takes time i guess
    }

    public override void OnTileExit()
    {
        player.timer.AddTime(1);
    }

    public void Start()
    {
        // for some reason, these sprites appear really small compared to blank green tiles
        //this.transform.localScale = Vector3.one * 3.5f;
        //fixed
    }
}
