using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public GameObject[] fireSources;
    public bool[] fireStarting;
    public float[] fireTimes;
    public IEnumerator[] fireCoroutines;


    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < fireSources.Length; x++)
        {
            fireStarting[x] = false;
            fireCoroutines[x] = StartFire(x);
            StartCoroutine(fireCoroutines[x]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < fireStarting.Length; x++)
        {
            if (fireStarting[x])
            {
                fireStarting[x] = false;
                StartCoroutine(FireBurn());
            }
        }  
    }

    IEnumerator StartFire(int pos)
    {
        yield return new WaitForSeconds(fireTimes[pos]);
        fireStarting[pos] = true;

    }

    IEnumerator FireBurn()
    {
        yield return new WaitForSeconds(10f);
        //Then we do game over
        Debug.Log("Game Over");
    }

    public void EndFire(int pos)
    {
        StopCoroutine(fireCoroutines[pos]);
    }


}
