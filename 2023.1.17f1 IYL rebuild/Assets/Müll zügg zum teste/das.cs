using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Das : MonoBehaviour
{
    public CompletedQuest completerrr;
    public TMP_Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void completion()
    {
        
        int value = StaticString.Xpforcompletion;
        levelText.text = value.ToString();
        StaticString.Xpforcompletion = 0;
    }
}
