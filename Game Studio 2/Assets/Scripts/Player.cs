using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Timer timer;
    public int timePerMove = 1;
    public Vector2Int gridDimensions, playerPos;
    public Tile[,] tiles;
    public Tile ShipTile;

    Stack timeStack, posStack;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new Tile[gridDimensions.x, gridDimensions.y];
        timeStack = new Stack();
        posStack = new Stack();
    }

    void HandleInputs()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (playerPos.y < gridDimensions.y - 1)
            {
                if (tiles[playerPos.x, playerPos.y + 1].passable)
                {
                    timeStack.Push(timer.tau);
                    posStack.Push(playerPos);
                    tiles[playerPos.x, playerPos.y].OnTileExit();
                    playerPos.y++;
                    timer.AddTime(timePerMove);
                    tiles[playerPos.x, playerPos.y].OnTileEnter();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (playerPos.y > 0)
            {
               if (tiles[playerPos.x, playerPos.y - 1].passable)
                {
                    timeStack.Push(timer.tau);
                    posStack.Push(playerPos);
                    tiles[playerPos.x, playerPos.y].OnTileExit();
                    playerPos.y--;
                    timer.AddTime(timePerMove);
                    tiles[playerPos.x, playerPos.y].OnTileEnter();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (playerPos.x > 0)
            {
                if (tiles[playerPos.x - 1, playerPos.y].passable)
                {
                    timeStack.Push(timer.tau);
                    posStack.Push(playerPos);
                    tiles[playerPos.x, playerPos.y].OnTileExit();
                    playerPos.x--;
                    timer.AddTime(timePerMove);
                    tiles[playerPos.x, playerPos.y].OnTileEnter();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (playerPos.x < gridDimensions.x - 1)
            {
                if (tiles[playerPos.x + 1, playerPos.y].passable)
                {
                    timeStack.Push(timer.tau);
                    posStack.Push(playerPos);
                    tiles[playerPos.x, playerPos.y].OnTileExit();
                    playerPos.x++;
                    timer.AddTime(timePerMove);
                    tiles[playerPos.x, playerPos.y].OnTileEnter();
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if(timeStack.Count > 0)
            {
                timer.tau = (int) timeStack.Pop();
            }

            if(posStack.Count > 0)
            {
                playerPos = (Vector2Int) posStack.Pop();
            }
        }

        transform.position = tiles[playerPos.x, playerPos.y].gameObject.transform.position;
    }
    
    public void ReturnToShip()
    {
        Debug.Log("Player.ReturnToShip()");

        playerPos.x = ShipTile.coord.x;
        playerPos.y = ShipTile.coord.y;

        transform.position = tiles[playerPos.x, playerPos.y].gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }
}
