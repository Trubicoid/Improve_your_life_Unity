using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBarITis : MonoBehaviour
    
{
    public int maxExp = 100;
    public int currentExp;
    public LevelUP xpbarre;

    // Start is called before the first frame update
    void Start()
    {
        currentExp = maxExp;
        xpbarre.SetMaxExp(maxExp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            GainErfahrung(20);
        }
    }
    void GainErfahrung(int dieseGuteErfahrung)
    {
        currentExp -= dieseGuteErfahrung;
        xpbarre.SetXP(currentExp);
    }
}
