using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genSphere : MonoBehaviour
{
    public GameObject prefabSphere;
    public int quantity = 10;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < quantity; i++)
        {
            float axisX = Random.Range(-20f, 20f);
            float axisY = Random.Range(0f, 20f);
            float axisZ = Random.Range(-20f, 20f);

         Vector3 position = new Vector3(axisX, axisY, axisZ);
         Instantiate(prefabSphere, position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
