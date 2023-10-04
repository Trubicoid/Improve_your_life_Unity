using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weekly2 : MonoBehaviour
{
public void Dailyhin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    } 
    public void DailyBack() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
