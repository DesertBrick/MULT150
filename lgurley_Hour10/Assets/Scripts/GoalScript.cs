using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private int scored = 0;
    private bool solved = false;
    public int required = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            scored++;
            other.GetComponent<Rigidbody>().isKinematic = true;
            if (scored >= required)
            {
                solved = true;
            }
        }
    }
    
    public bool IsSolved()
    {
        return solved;
    }
}
