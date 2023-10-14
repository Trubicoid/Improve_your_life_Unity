using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelUP : MonoBehaviour
{
    public Slider slider;
    int flowingxp = 0;

    //public void SetMinExp(int xp)
    //{
    //  slider.minValue = xp;
    //slider.value = xp;
    //}

    public void Start()
    {
       slider.value = 0;
       slider.maxValue = maxValstatic.slidermaxvaluE;
        //slider.maxValue = 100;
        Debug.Log("start");


    }
    public void Update()
    {
        
        flowingxp = StaticString.Xpforcompletion;
        slider.value = flowingxp;
        
        if (slider.value >= slider.maxValue)
        {
            maxValstatic.slidermaxvaluE += 10;
            //slider.value = 0;
            Debug.Log(slider.maxValue);
            LvlTextStatic.LvlTxt += 1;
            StaticString.Xpforcompletion = 0;
            //LevelUp();
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
