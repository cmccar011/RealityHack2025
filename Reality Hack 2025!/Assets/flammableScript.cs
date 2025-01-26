using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flammableScript : MonoBehaviour
{

    public bool smoking = false;
    public bool onFire = false;
    public float igniteCount = 0;
    public int igniteRate = 1;
    public int igniteStage = 0; //0 is stable, 1 is smoking, 2 is ignited

    public ParticleSystem smokeSys;

    public ParticleSystem fireSys;


    //Audio Sources
    public AudioSource as1;
    public AudioSource as2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.Clamp(igniteStage, 0, 2);
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
       int igniteNum = Random.Range(0, 2);
       Debug.Log(igniteNum);
       //Debug.Log(igniteNum); 
       if (igniteNum == 0)
       {
        //Ignite();
        igniteStage++;
        if (igniteStage == 1)
        {
                as1.Play();
            Smoke();
            Debug.Log("Smoke Fired");
        }
        else if (igniteStage == 2)
        {
                as2.Play();
            Fire();
        }
       }
    }

    public void Smoke()
    {  
        Debug.Log("Smoke Start");
        smoking = true;
        smokeSys.Play();
        Debug.Log("Smoke End");
    }

    public void Fire()
    {  
        Debug.Log("Fire Start");
        onFire = true;
        fireSys.Play();
        Debug.Log("Fire End");
    }


    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Extinguish"))
        {
            //Debug.Log("Collide");
            onFire = false;
            smoking = false;
            smokeSys.Stop();
            fireSys.Stop();
            igniteStage = 0;
        }
    }
}
