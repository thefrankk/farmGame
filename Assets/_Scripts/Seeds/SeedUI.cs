using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedUI : ItemUI<Seed>
{

    [SerializeField] private SeedBook.SeedTypes currentSeedType;

    public override void DoWork(GridObject gridObject)
    {
        if (gridObject.GetSeed() != null)
        {
            MouseWorld.Instance.DeleteDragObject();
            return;
        }

        Instantiate(MouseWorld.Instance.GetDragObject(), gridObject.transform.position, Quaternion.identity, gridObject.transform);
        Seed seedType = GetItemType();
        gridObject.SetSeed(seedType);
        MouseWorld.Instance.DeleteDragObject();
    }

    private void Start()
    {
        InitializeItem();
    }

    protected override void InitializeItem()
    {
        currentItemType = (int)currentSeedType;
    }

   
}
