using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y += 5 * Time.deltaTime, gameObject.transform.eulerAngles.z);
        gameObject.transform.Rotate(0, 5 * Time.deltaTime, 0, Space.World);
    }
}
