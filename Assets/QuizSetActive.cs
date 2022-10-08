using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizSetActive : MonoBehaviour
{
    public GameObject quizUI;
    public GameObject quizUI2;
    public GameObject quizUI3;
    public GameObject quizUI4;
    public GameObject quizUI5;

    bool quizActive = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(InviLadder.seedCounterquiz == 3 && quizActive == false)
        {
            quizUI.SetActive(true);
            quizActive = true;
        }

        if (InviLadder.seedCounterquiz == 6 && quizActive == true)
        {
            quizUI2.SetActive(true);
            quizActive = false;
        }
        if (InviLadder.seedCounterquiz == 9 && quizActive == false)
        {
            quizUI3.SetActive(true);
            quizActive = true;
        }
        if (InviLadder.seedCounterquiz == 12 && quizActive == true)
        {
            quizUI4.SetActive(true);
            quizActive = false;
        }
        if (InviLadder.seedCounterquiz == 15 && quizActive == false)
        {
            quizUI5.SetActive(true);
            quizActive = true;

        }











    }
}
