using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameObject OtherPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var pos = OtherPoint.transform.position - new Vector3(0,0,i);
            Instantiate(prefab,pos,OtherPoint.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(prefab, transform.position, transform.rotation);
    }
}
