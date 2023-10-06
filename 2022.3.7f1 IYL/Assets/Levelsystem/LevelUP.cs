using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelUP : MonoBehaviour
{
    public Slider slider;
    int flowingxp = 0;
    int lululul = 100;

    //public void SetMinExp(int xp)
    //{
    //  slider.minValue = xp;
    //slider.value = xp;
    //}

    public void Start()
    {
       slider.value = 0;
       slider.maxValue = 100;


    }
    public void Update()
    {
        slider.maxValue = lululul;
        flowingxp = StaticString.Xpforcompletion;
        slider.value = flowingxp;
        if (slider.value >= slider.maxValue)
        {
            slider.maxValue += 10;
            lululul += 10;
            //slider.value = 0;
            StaticString.Xpforcompletion = 0;
            LevelUp();
        }
    }
    public void SetXP(int xp)
    {
        slider.value = xp;
        slider.value += flowingxp;
    }
    public void CheckForLevelUp()
    {
        if (slider.value >= slider.maxValue)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        //slider.value = 0;
        slider.maxValue += 10;
    }
}
