using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    private bool movingRight = true;
    public Transform groundDetect;
    public float rayDist;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate
            (Vector2.right * speed * Time.deltaTime);

        //Patrol
        RaycastHit2D groundChecker = Physics2D.Raycast(groundDetect.position,Vector2.down,rayDist);
        if (groundChecker.collider == false || groundChecker.collider.tag=="enemy")
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

    }



}
