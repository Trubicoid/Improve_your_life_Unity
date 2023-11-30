using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antilag : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        Application.targetFrameRate = 120;

    }
}
