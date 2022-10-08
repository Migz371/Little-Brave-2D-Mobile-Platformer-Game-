using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seedCount : MonoBehaviour
{
    int seedCounterUI=0;
    public Text seedText;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        seedCounterUI = InviLadder.seedCounter;
        seedText.text = " " + seedCounterUI;

    }
}
