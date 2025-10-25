using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sens = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

        float mouseY = Input.GetAxis("Mouse Y") * sens;
        float mouseX = Input.GetAxis("Mouse X") * sens;
        
        transform.Translate(mouseX, mouseY, 0f);
    }
}
