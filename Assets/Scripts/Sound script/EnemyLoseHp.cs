using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoseHp : MonoBehaviour
{
    public static AudioSource Enemyhplose;
    void Start()
    {
        Enemyhplose = GetComponent<AudioSource>();

    }

    public void Enemyloseshp()
    {
        StartCoroutine(Enemyloseshps());
    }

    IEnumerator Enemyloseshps()
    {
        yield return new WaitForSeconds(1);

        Enemyhplose.Play();
    }
}
