using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksHandler : MonoBehaviour
{
    private Books<Seed> seedBook = new SeedBook();
    private Books<Tool> toolBook = new ToolsBook();



    private void Awake()
    {
        seedBook.CreateBook();
        toolBook.CreateBook();
    }





}
