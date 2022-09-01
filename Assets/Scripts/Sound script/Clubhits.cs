using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clubhits : MonoBehaviour
{
    public static AudioSource hitclub;
    void Start()
    {
        hitclub = GetComponent<AudioSource>();

    }

    public void hitsclub()
    {
        hitclub.Play();
    }

   
}
