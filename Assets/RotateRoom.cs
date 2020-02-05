using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var angle = Time.fixedTime / (360 * 100);
        transform.RotateAround(transform.position, transform.right, 2 * Time.deltaTime);
    }
}
