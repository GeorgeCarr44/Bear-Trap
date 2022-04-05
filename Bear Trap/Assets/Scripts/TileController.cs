using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public int XPosition;
    public int YPosition;
    public TileState State;
    public int PlayerSpawnID;

    /// <summary>
    /// Tile Constructor
    /// </summary>
    /// <param name="x">The X position</param>
    /// <param name="y">The Y position</param>
    /// <param name="state">The state of the tile defaults to Empty</param>
    public void SetTileDetails(int x, int y, int spawnID)
    {
        XPosition = x;
        YPosition = y;
        State = TileState.Empty;
        PlayerSpawnID = spawnID;
    }

    public enum TileState
    {
        Empty,
        Trap
    }

    public void Start()
    {
        if(PlayerSpawnID > 0)
        {
            //Spawn player
        }
    }
}
