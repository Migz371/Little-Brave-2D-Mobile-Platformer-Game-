using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InviLadder : MonoBehaviour
{
    public static int seedCounterquiz = 0;
    public static int seedCounter=0;
    public static int score = 0;
    public GameObject inviRope;

    // Start is called before the first frame update
    void Start()
    {
        inviRope.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(seedCounter);
        if (seedCounter >= 3)
        {
            inviRope.SetActive(true);
        }

    }





}
