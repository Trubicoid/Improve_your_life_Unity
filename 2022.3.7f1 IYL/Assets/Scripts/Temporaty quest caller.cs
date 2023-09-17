using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class Temporatyquestcaller : ScriptableObject
{

    public static List<Quests> listeners = new List<Quests>();



    public void Raise()
    {
        for (int i = 0; 1 < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }
    public void RegisterListener(Quests listener)
    {
        if(listeners.Contains(listener))   
            listeners.Add(listener);
    }


    public void UnregisterListener(Quests listener)
    {
        if(listeners.Contains(listener))   
            listeners.Remove(listener);
    }
}
