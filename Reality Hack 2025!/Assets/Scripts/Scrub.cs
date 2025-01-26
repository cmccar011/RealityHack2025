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
            if (other.gameObject.GetComponent<flammableScript>().igniteStage != 2)
            {
                other.gameObject.GetComponent<flammableScript>().igniteStage = 0;
                other.gameObject.GetComponent<flammableScript>().StopFires();
            }
        }
    }
}
