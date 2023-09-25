using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelUP : MonoBehaviour
{
    public Slider slider;

    public void SetMaxExp (int xp)
    {
        slider.maxValue = xp;
        slider.value = xp;
    }

    public void SetXP(int xp)
    {
        slider.value = xp;
    }
}
