using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Books<T>
{
    protected static Dictionary<int, T> itemDictionary = new Dictionary<int, T>();

    public abstract void CreateBook();

    protected T GetItemInDictionary(int id) => itemDictionary[id];
    public static Dictionary<int, T> GetDictionary() => itemDictionary;


}
