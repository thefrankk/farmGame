using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEditor.Progress;

public class Grid 
{


    private int heigth;
    private int width;
    private float cellSize;



    GridBox[,] gridBoxes;
    public Grid(float cellSize, int w, int h)
    {
        this.cellSize = cellSize;
        heigth = h;
        width = w;

        CreateGrid();
    }


    public void CreateGrid()
    {
        gridBoxes = new GridBox[width, heigth];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < heigth; y++)
            {
                gridBoxes[x, y] = new GridBox(x, y, this.GetHashCode());

                Debug.Log($"x: {x} y: {y}"); 
            }
        }
    }

    public void CreateGridObject(GridObject gridObject, Transform parent, float boxSize)
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < heigth; y++)
            {
                gridObject = GameObject.Instantiate(gridObject, parent.position + new Vector3(x, y, 0) * cellSize, Quaternion.identity);
                gridObject.SetGridBox(gridBoxes[x, y]);
                gridObject.transform.SetParent(parent);
                gridObject.transform.localScale = new Vector3(boxSize, boxSize, 0);


            }
        }

    }


    public GridBox[,] GetCurrentGrid() => gridBoxes;

    
    
}

public struct GridBox
{
    public int id;
    public int x;
    public int y;

    

    public GridBox(int x, int y, int id)
    {
        this.id = id;
        this.x = x;
        this.y = y;
    }
}
