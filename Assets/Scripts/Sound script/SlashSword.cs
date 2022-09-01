using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashSword : MonoBehaviour
{
    public static AudioSource SlashingSword;
    void Start()
    {
        SlashingSword = GetComponent<AudioSource>();

    }

    public void SlashesSword()
    {
        SlashingSword.Play();
    }
}