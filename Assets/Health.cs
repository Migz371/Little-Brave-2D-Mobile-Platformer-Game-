using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthSlider;
    public float health;
    public GameObject gameover;


    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value <= 0 || Player.nalaglag==true)
        {
            gameover.SetActive(true);
            Player.nalaglag = false;
            InviLadder.score = 0;
            InviLadder.seedCounter = 0;
            InviLadder.seedCounterquiz = 0;
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
}
