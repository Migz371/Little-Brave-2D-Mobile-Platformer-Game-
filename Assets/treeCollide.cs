using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeCollide : MonoBehaviour
{
    public GameObject treeUpdate;
    Transform dryTree;

    // Start is called before the first frame update
    void Start()
    {
        dryTree = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            InviLadder.seedCounter += 100;
            GameObject newTree = Instantiate(treeUpdate,dryTree.transform.position, Quaternion.identity) as GameObject;
            newTree.transform.position += Vector3.up * .8f;
            InviLadder.seedCounterquiz += 1;
            Destroy(gameObject);
        }
    }
}
