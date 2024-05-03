
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class CardDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler//, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private bool instantiateVisual = true;
    private Vector3 offset;

    [Header("Movement")]
    [SerializeField] private float moveSpeedLimit = 50;

    [Header("Selection")]
    public bool selected;
    public float selectionOffset = 50;

    [Header("States")]
    public bool isHovering;
    public bool isDragging;
    [HideInInspector] public bool wasDragged;


    void Update()
    {
    
        if (isDragging)
        {
            Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - offset;
            Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;
            Vector2 velocity = direction * Mathf.Min(moveSpeedLimit, Vector2.Distance(transform.position, targetPosition) / Time.deltaTime);
            transform.Translate(velocity * Time.deltaTime);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = mousePosition - (Vector2)transform.position;
        isDragging = true;
        Debug.Log("On Begin Dragggggg!!!!!!!");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On Dragggggg!!!!!!!");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        Debug.Log("On End Dragggggg!!!!!!!");
    }

}
