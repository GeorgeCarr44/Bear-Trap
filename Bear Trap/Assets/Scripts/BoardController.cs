using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    public int Width;
    public int Length;
    public GameObject TilePrefab;


    public List<TileController> Board = new List<TileController>();

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
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Length; y++)
            {
                Vector3 pos = new Vector3(x, 0, y);
                Instantiate(TilePrefab, pos, new Quaternion());
            }
        }
    }
    private void DrawTiles()
    {
        throw new NotImplementedException();
    }
}
