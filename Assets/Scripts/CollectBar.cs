using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectBar : MonoBehaviour
{
    public GameObject target;
    public Vector2 offset;

    public Camera maincamera;
    
    public Slider slider;

    public Image fill;


    void Update()
    {
        ((RectTransform)transform).anchoredPosition = maincamera.WorldToScreenPoint(target.transform.position) + (Vector3)offset;
    }

    public void Initial()
    {
        slider.maxValue = 10;
        slider.value = 0;
    }

    public void Collected(int val)
    {
        slider.value = val;
    }
}
