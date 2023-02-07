using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsBook : Books<Tool>
{

    public enum ToolsType
    {
        Sickle,
        WateringCan,
    }

    public override void CreateBook()
    {
        itemDictionary.Add(0, new SickleTool());
        itemDictionary.Add(1, new WateringCanTool());
    }
}
