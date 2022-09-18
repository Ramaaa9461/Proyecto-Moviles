using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] RectTransform stick = null;
    [SerializeField] Image background = null;

    public string player = "";
    public float limit = 250f;

    public void OnPointerDown(PointerEventData eventData)
    {
        stick.anchoredPosition = ConverToLocal(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = ConverToLocal(eventData);

        if (pos.magnitude > limit)
        {
            pos = pos.normalized * limit;
        }

        stick.anchoredPosition = pos;

        float x = pos.x / limit;
        float y = pos.y / limit;

        SetHorizontal(x);
        SetVertical(y);
      }

    public void OnPointerUp(PointerEventData eventData)
    {
        stick.anchoredPosition = Vector2.zero;
        SetHorizontal(0.0f);
        SetVertical(0.0f);
}

    void OnDisable()
    {
        SetHorizontal(0.0f);
        SetVertical(0.0f);
    }

    private void SetHorizontal(float x)
    {
        InputManager.Instance.Setaxis("Horizontal" + player, x);
    }


    private void SetVertical(float y)
    {
        InputManager.Instance.Setaxis("Vertical" + player, y);
    }



    private Vector2 ConverToLocal(PointerEventData eventData)
    {
        Vector2 newPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform as RectTransform, eventData.position, eventData.enterEventCamera, out newPos);

        return newPos;
    }

}
