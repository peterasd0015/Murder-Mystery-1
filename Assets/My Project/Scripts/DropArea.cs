using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler
{
    [SerializeField] InventoryItem.Types type;
    GameObject item;

    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem _item = eventData.pointerDrag.gameObject.GetComponent<InventoryItem>();
        if (_item.itemType == type)
        {
            if (item != null)
            {
                Transform _parent = eventData.pointerDrag.gameObject.GetComponent<Draggable> ().originalParent;
                item.GetComponent<CanvasGroup>().blocksRaycasts = true;
                item.GetComponent<Draggable > ().used = false;
                item.GetComponent<Draggable>().originalParent = _parent;
                item.transform.SetParent(_parent);
            }
            item = eventData.pointerDrag.gameObject;
            eventData.pointerDrag.gameObject.GetComponent<Draggable>().used = true;
            eventData.pointerDrag.gameObject.transform.SetParent (transform);

            _item.DropEvent();

        }
    }
}
