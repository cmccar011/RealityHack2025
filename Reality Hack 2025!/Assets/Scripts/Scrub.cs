using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grill"))
        {
             //Find a way to disable the grill's ability to combust


        }
    }
}
