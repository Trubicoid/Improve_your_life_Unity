using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelUP : MonoBehaviour
{
    public Slider slider;
 

    public void SetMinExp(int xp)
    {
        slider.minValue = xp;
        slider.value = xp;
    }

    public void SetXP(int xp)
    {
        slider.value = xp;
    }
    public void CheckForLevelUp()
    {
        if (slider.value >= slider.maxValue)
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        slider.value = 0;
        slider.maxValue += 10;
    }
}
