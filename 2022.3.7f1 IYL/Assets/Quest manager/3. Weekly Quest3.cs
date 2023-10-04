using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weekly3 : MonoBehaviour
{
public void Dailyhin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    } 
    public void DailyBack() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
