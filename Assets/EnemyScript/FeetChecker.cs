using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetChecker : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyHeadCheck>())
        {
            Destroy(transform.parent.gameObject);
        }
    }

}
