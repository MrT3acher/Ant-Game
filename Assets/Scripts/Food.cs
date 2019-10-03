using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int value;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Eaten(col.gameObject);
    }
    public void Eaten(GameObject g)
    {
        g.GetComponent<AntGroup>().Increase(value);
        Destroy(gameObject);
    }
}
