using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsUI : ItemUI<Tool>
{
    [SerializeField] private ToolsBook.ToolsType currentTool;

    public override void DoWork(GridObject gridObject)
    {
        ToolsBook.GetDictionary()[(int)currentTool].DoToolTask();
    }

    protected override void InitializeItem()
    {
        currentItemType = (int)currentTool;
        base.SetItemInMouseManager();
    }

    private void Start()
    {
        InitializeItem();
    }


}
