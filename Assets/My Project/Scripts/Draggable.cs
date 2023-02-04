using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    CanvasGroup cg;
    [HideInInspector] public Transform originalParent;
    [HideInInspector] public bool used;
    private void Awake()
    {
        cg = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        cg.blocksRaycasts = false;
        originalParent = transform.parent;
        transform.SetParent(transform.parent.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!used)
        {
            transform.SetParent(originalParent);
            cg.blocksRaycasts = true;
        }
    }
}
