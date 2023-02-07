using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{

    [SerializeField] private GridObject gridObject;


    private Grid grid;

    [SerializeField] private float padding = 1.3f;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private float boxSize;


    private void Start()
    {

        grid = new Grid(padding, width, height);

        grid.CreateGridObject(gridObject, this.transform, boxSize);

    }

}
