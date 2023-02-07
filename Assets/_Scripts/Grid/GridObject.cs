using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{

    private Seed currentSeed;

    private GridBox currentGrid;


    private int xPosition;
    private int yPosition;

    private void Start()
    {
        xPosition = currentGrid.x;
        yPosition = currentGrid.y;

        this.name = $"GridObject: X: {xPosition}, Y:{yPosition}";
    }

    private void OnMouseUp()
    {
        Debug.Log($"GridObject: X: {xPosition}, Y:{yPosition}");

        if(currentSeed != null)
        {
            Debug.Log($"Current Seed: {currentSeed.ToString()}");

        }
    }

    public void SetGridBox(GridBox gridBox)
    {
        currentGrid = gridBox;
    }

    public void SetSeed(Seed seed) => currentSeed = seed;
    public Seed GetSeed() => currentSeed;
}
