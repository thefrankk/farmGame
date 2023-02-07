using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    public static MouseWorld Instance;

    private Transform dragObject;

    private bool isDraggin;

    [SerializeField] private LayerMask mousePlaneLayermask;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
            Destroy(Instance);
    }



    public Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // Debug.Log(Mathf.CeilToInt(mouseWorldPos.x) + " " + Mathf.CeilToInt(mouseWorldPos.y));
        return mouseWorldPos;
    }


    public object GetWorldPositionRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(GetMouseWorldPosition(), GetMouseWorldPosition(), 1 << mousePlaneLayermask.value);
        return hit.collider ? hit.collider.transform : null;
    }


    public void SetDragObject(Transform dragObject) {
        this.dragObject = dragObject;
        isDraggin = true;
    }

    public Transform GetDragObject() => dragObject;

    public void DeleteDragObject()
    {
        isDraggin = false;
        Destroy(dragObject.gameObject);
    }




    public bool IsDraggin() => isDraggin;

}
