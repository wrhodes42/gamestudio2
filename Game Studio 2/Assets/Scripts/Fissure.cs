using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fissure : Tile
{
    List<Transform> allFissures = new List<Transform>();

    public void Start()
    {
        
    }

    public override void OnTileEnter()
    {
        player.timer.AddTime(1); // swimming takes time i guess
    }

    public override void OnTileExit()
    {
        
    }
}
