using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeadCheck : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D feetRigid;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FeetChecker>())
        {
            feetRigid.velocity=new Vector2(feetRigid.velocity.x,0f);
            feetRigid.AddForce(Vector2.up * 300f);
        }
    }

}
