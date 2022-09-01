using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losehp : MonoBehaviour
{
    public static AudioSource hplose;
    void Start()
    {
        hplose= GetComponent<AudioSource>();
        
    }

    public void loseshp()
    {
        StartCoroutine(loseshps());
    }

    IEnumerator loseshps()
    {
        yield return new WaitForSeconds(1);

        hplose.Play();
    }
}
