using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grill : flammableScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Ignite()
    {
        Debug.Log("Ignition Start");
        onFire = true;
        particleSys.Play();
        Debug.Log("Ignition End");
    }
}
