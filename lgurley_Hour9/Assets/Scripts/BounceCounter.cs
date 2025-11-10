using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int Bounces { get; private set; } = 0;
    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Bounces++;
        print("Total Bounces: "+Bounces);
    }
}
