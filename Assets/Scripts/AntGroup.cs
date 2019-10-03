using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntGroup : MonoBehaviour
{
    public int count;
    
    public void Increase(int value)
    {
        count += value;
            
       
    }
    void OnCollisionEnter(Collision2D col)
    {
       
    }

    public void Decrease(int value)
    {
       
    }
}
