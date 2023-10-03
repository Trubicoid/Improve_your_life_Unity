using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class LevelUpSystem : MonoBehaviour
{
    public TMP_Text levelText;
    public TMP_Text xpText;

    private int currentLevel = 1;
    private int currentXP = 0;
    private int xpToLevelUp = 100;

    private void Start()
    {
        UpdateUI();
    }

    private void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
      // {
          //GainXP(1);
     // }
    }

    
   

    private void GainXP(int amount)
    {
        currentXP += amount;
        CheckForLevelUp();
        UpdateUI();
    }

    private void CheckForLevelUp()
    {
        if (currentXP >= xpToLevelUp)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        currentLevel++;
        currentXP = 0;
        xpToLevelUp += 10;
    }

    private void UpdateUI()
    {
        levelText.text = "Level: " + currentLevel;
        xpText.text = "XP: " + currentXP + " / " + xpToLevelUp;
    }

    //EVENT SYSTEM DO NOT TOUCH!
    public void Questcompleted(Component sender, object data)
    {
        if(data is int)
        {
            int lvl_up = (int)data;
            GainXP(lvl_up);
        }
    }
}
