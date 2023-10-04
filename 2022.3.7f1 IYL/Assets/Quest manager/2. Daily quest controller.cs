using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeuesScipt : MonoBehaviour
{
public void Dailyhin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    } 
    public void DailyBack() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
