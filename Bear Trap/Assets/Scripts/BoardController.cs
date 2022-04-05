using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    public int Width;
    public int Length;
    public GameObject TilePrefab;

    public List<Vector2> PlayerSpawns;

    private List<TileController> Board = new List<TileController>();

    // Start is called before the first frame update
    void Start()
    {
        //Create the 2d list of game objects
        CreateTiles();

        //Call them to draw

        //DrawTiles();
    }


    private void CreateTiles()
    {
        //Not doing 0 baised
        for (int xPos = 1; xPos < Width + 1; xPos++)
        {
            for (int yPos = 1; yPos < Length + 1; yPos++)
            {
                //Zeroing the position
                Vector3 pos = new Vector3(xPos - 1, 0, yPos -1);
                var tmpObj = Instantiate(TilePrefab, pos, new Quaternion());
                TileController tileController = tmpObj.GetComponent<TileController>();
                // Adding one to this as -1 is not found
                int SpawnId = PlayerSpawns.FindIndex(s => s.x == xPos && s.y == yPos) + 1;
                tileController.SetTileDetails(xPos, yPos, SpawnId);
            }
        }
    }
    private void DrawTiles()
    {
        throw new NotImplementedException();
    }
}
public class PlayerSpawn
{
    public int X;
    public int Y;
}
