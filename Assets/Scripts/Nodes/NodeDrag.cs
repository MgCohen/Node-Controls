using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NodeDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Node node;
    Vector2 offset;
    Collider2D col;

    private void Start()
    {
        node = GetComponent<Node>();
        col = GetComponent<Collider2D>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        col.enabled = false;
        offset = (Vector2)transform.position - Pointer.Position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Pointer.Position + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        CheckDrop();
        col.enabled = true;
    }

    void CheckDrop()
    {
        Slot slot = Pointer.GetObjectOnPointer<Slot>();
        if (slot)
        {
            slot.DropNode(node);
        }
        else
        {
            transform.position = node.currentSlot.transform.position;
        }
    }


}
