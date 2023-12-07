using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text quest_text_UI;
    private void Update()
    {
        if (quest_text_UI != null)
        {


            if (!StaticString.T_Daily_1)
            {
                DateTime temp = StaticString.dateCurrent_daily_1.AddDays(1);
                TimeSpan remainingTime = temp - DateTime.Now;
                quest_text_UI.text = "Daily 1 available in: \n" + remainingTime.Hours + "hours" + remainingTime.Minutes + "minutes";
            }
            else
            {
                quest_text_UI.text = "Daily 1";
            }

        }
    }
    public void playGame() 
    {
        if(StaticString.T_Daily_1)
        {
            StaticString.Daily_1 = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            SceneManager.LoadScene("Daily_Quests");
        }
    } 
public void Back() 
    {
        StaticString.Daily_1 = false;
        StaticString.Daily_2 = false;
        StaticString.Weekly_1 = false;
        StaticString.Weekly_2 = false;
        StaticString.Weekly_3 = false;
        StaticString.Weekly_4 = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        StaticString.startup = false;
        SceneManager.LoadScene("jiaming");
    }
    
}
