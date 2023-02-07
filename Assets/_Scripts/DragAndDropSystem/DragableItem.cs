using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using static UnityEditor.Progress;

public class DragableItem: MonoBehaviour 
{

    private IDragginItem itemUI;

    Transform dragableItem;

    private void OnMouseDown()
    {
        dragableItem = Instantiate(this.transform, MouseWorld.Instance.GetMouseWorldPosition(), Quaternion.identity);

        itemUI = GetComponent<IDragginItem>();

        itemUI.SetItemInMouseManager();
        Destroy(dragableItem.GetComponent<BoxCollider2D>()); 
        MouseWorld.Instance.SetDragObject(dragableItem);
    }

    private void OnMouseDrag()
    {
        dragableItem.transform.localPosition = new Vector3(MouseWorld.Instance.GetMouseWorldPosition().x, MouseWorld.Instance.GetMouseWorldPosition().y, 0);
    }

   
}
