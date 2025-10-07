using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int a = 2;
    public int b = 4;
    public int c = 8;
    public int sum;
    // Start is called before the first frame update
    void Start()
    {
        sum = a + b + c;
        sum++;
        print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
