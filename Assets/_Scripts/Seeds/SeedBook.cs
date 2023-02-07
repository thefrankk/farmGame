using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBook : Books<Seed>
{

    public enum SeedTypes
    {
        Tomato,
        Carrot,
    }



    public override void CreateBook()
    {
       itemDictionary.Add(0, new TomatoSeed());
       itemDictionary.Add(1, new CarrotSeed());
    }
  
}
