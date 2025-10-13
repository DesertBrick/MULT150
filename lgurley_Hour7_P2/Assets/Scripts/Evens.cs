using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int count = 21; count <= 100; count++)
        {
            if (count % 2 == 0)
            {
                Debug.Log(count);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
