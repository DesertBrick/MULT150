using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light ight;
    
    void Start()
    {
        ight = GetComponent<Light>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
            ight.enabled = !ight.enabled;
            //light.enabled = !light.enabled; "Outdated API says Unity compiling"
    }
}
