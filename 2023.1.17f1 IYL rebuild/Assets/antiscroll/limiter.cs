using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class limiter : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float maxScrollLimit = 0.65f;

    void Update()
    {
        // Limit scrolling by clamping the vertical normalized position
        scrollRect.verticalNormalizedPosition = Mathf.Clamp(scrollRect.verticalNormalizedPosition, maxScrollLimit, 1.025f);
    }
}
