using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Player player;
    public Vector2Int coord;
    // Start is called before the first frame update
    void Start()
    {
        player.tiles[coord.x, coord.y] = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
