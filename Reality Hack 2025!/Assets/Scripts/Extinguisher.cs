using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{


    //Works by pulling a trigger when it is held

    //We need a way to see if this is being held


    public ParticleSystem partSys;
    public bool held;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        held = gameObject.transform.position.y > 0;
        if (held)
        {
            float detection = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch);
            if (detection > 0.5)
            {
                partSys.Play();
            }
            else
            {
                partSys.Stop();
            }
        }
        
    }


    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Flammable"))
        {
            //extinguish the fire
        }
    }
}
