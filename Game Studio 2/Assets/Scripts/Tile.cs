using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    bool linkedToPlayer = false;
    public Player player;
    public Vector2Int coord;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (!linkedToPlayer)
        {
            player.tiles[coord.x, coord.y] = this;
            linkedToPlayer = true;
        }
    }
}
