using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weekly4 : MonoBehaviour
{
public void Dailyhin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    } 
    public void DailyBack() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
}
