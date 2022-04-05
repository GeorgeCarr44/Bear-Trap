using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public int XPosition;
    public int YPosition;
    public TileState State;

    /// <summary>
    /// Tile Constructor
    /// </summary>
    /// <param name="x">The X position</param>
    /// <param name="y">The Y position</param>
    /// <param name="state">The state of the tile defaults to Empty</param>
    public TileController(int x, int y, TileState state = TileState.Empty)
    {
        XPosition = x;
        YPosition = y;
        State = state;
    }

    public enum TileState
    {
        Empty,
        Trap,
        Player1,
        Player2
    }
}
