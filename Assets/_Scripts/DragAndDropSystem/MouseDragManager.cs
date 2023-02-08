using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragManager : MonoBehaviour
{
    //Dependency injection
    private static IDragginItem DragginItem;

    public static void SetDragginItem(IDragginItem dragginItem)
    {
        DragginItem = dragginItem;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (!MouseWorld.Instance.IsDraggin()) return;


            if (checkForObjectInPosition()) return;

            Transform gridGameObject = MouseWorld.Instance.GetWorldPositionRay() as Transform;

            (bool, GridObject) componentInPosition = checkForComponentInPosition(gridGameObject);

            if (!componentInPosition.Item1) return;


            DragginItem.DoWork(componentInPosition.Item2);

        }
    }



    private bool checkForObjectInPosition()
    {
        bool isObjectNull = MouseWorld.Instance.GetWorldPositionRay() is null;

        if(isObjectNull) MouseWorld.Instance.DeleteDragObject();

        return isObjectNull;
    }

    private (bool, GridObject) checkForComponentInPosition(Transform gridGameObject)
    {
        bool isComponentNull = gridGameObject.TryGetComponent<GridObject>(out GridObject gridObject);

        Debug.Log(gridGameObject);
        Debug.Log(gridObject);

        if(isComponentNull) MouseWorld.Instance.DeleteDragObject();

        return (isComponentNull, gridObject);
    }

}


//Odio aqui