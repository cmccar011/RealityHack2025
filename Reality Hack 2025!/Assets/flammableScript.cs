using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flammableScript : MonoBehaviour
{

    public bool onFire = false;
    public float igniteCount = 0;
    public int igniteRate = 1;

    public ParticleSystem particleSys;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        igniteCount +=  igniteRate * Time.deltaTime;
        //Debug.Log(igniteCount);
        if (igniteCount >= 4)
        {
            IgniteCheck();
            igniteCount = 0;
            Debug.Log(onFire);
        }
    }

    public void IgniteCheck()
    {
       int igniteNum = Random.Range(0, 3);
       Debug.Log(igniteNum);
       //Debug.Log(igniteNum); 
       if (igniteNum == 0)
       {
        Ignite();
       }
    }

    public void Ignite()
    {  
        Debug.Log("Ignition Start");
        onFire = true;
        particleSys.Play();
        Debug.Log("Ignition End");
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Extinguish"))
        {
            //Debug.Log("Collide");
            onFire = false;
            particleSys.Stop();
        }
    }
}
