using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemUI<T> : MonoBehaviour, IDragginItem
{
    protected int currentItemType;

    public T GetItemType() => Books<T>.GetDictionary()[((int)currentItemType)];

    public void SetItemInMouseManager() => MouseDragManager.SetDragginItem(this);

    protected abstract void InitializeItem();


    public abstract void DoWork(GridObject gridObject);
    //.
    //.
    
}
