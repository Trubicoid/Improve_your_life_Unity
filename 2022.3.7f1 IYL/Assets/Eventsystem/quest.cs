using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public GameEvent quest_completed;
    int xp_gain = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            quest_completed.Raise(this, xp_gain);
            Debug.Log("Raised");
        }
    }

    public void test()
    {

    }
}
