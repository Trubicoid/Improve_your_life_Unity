using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public quest Quester;
    // Start is called before the first frame update
    public void testQuester()
    {
        GameObject gameObject = new GameObject("quest");
        this.Quester = gameObject.AddComponent<quest>();
        this.Quester.questcompleted();
    }
}
