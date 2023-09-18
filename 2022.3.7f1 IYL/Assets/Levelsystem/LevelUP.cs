using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelUP : MonoBehaviour
{
    public Slider slider;

    public void SetXP(int xp)
    {
        slider.value = xp;
    }
}
