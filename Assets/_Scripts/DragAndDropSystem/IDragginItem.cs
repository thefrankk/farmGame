using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDragginItem 
{
    public abstract void DoWork(GridObject gridObject);
    public void SetItemInMouseManager();
}
