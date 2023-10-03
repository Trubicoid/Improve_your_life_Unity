using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBarITis : MonoBehaviour
    
{
    public int maxExp = 0;
    public int currentExp;
    private int xpToLevelUp = 100;
    private int currentLevel = 1;
    public LevelUP xpbarre;

    // Start is called before the first frame update
    void Start()
    {
        currentExp = maxExp;
        xpbarre.SetMinExp(maxExp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GainErfahrung(10);
        }
    }
    //////////////////////////////////////////////////////////
    private void GainErfahrung(int amount)
    {
        currentExp += amount;
        xpbarre.SetXP(currentExp);
        CheckForLevelUp();
        //UpdateUI();
    }

    private void CheckForLevelUp()
    {
        if (currentExp >= xpToLevelUp)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        currentLevel++;
        currentExp = 0;
        xpToLevelUp += 10;
    }
    //
    //void GainErfahrung(int dieseGuteErfahrung)
    //{
     //   currentExp += dieseGuteErfahrung;
     //   xpbarre.SetXP(currentExp);
   // }
}
