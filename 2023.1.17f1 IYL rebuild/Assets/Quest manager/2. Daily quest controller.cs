using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeuesScipt : MonoBehaviour
{
public void Dailyhin() 
    {
        StaticString.Daily_2 = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
        SceneManager.LoadScene("Daily_Quests");
    } 
public void DailyBack() 
    {
        StaticString.Daily_2 = false;
        Debug.LogWarning("D2 False");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
}
