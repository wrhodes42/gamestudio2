using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{ 
    public Vector2Int gridDimensions, playerPos;
    public Tile[,] tiles;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new Tile[gridDimensions.x, gridDimensions.y];
    }

    void HandleInputs()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (playerPos.y < gridDimensions.y - 1)
            {
                playerPos.y++;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (playerPos.y > 0)
            {
                playerPos.y--;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (playerPos.x > 0)
            {
                playerPos.x--;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (playerPos.x < gridDimensions.x - 1)
            {
                playerPos.x++;
            }
        }
        transform.position = tiles[playerPos.x, playerPos.y].gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }
}
