using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHeart : MonoBehaviour
{
    public int Enemyhealth;
    public int Enemyhearts;

    public Image[] EnemyheartImg;
    public Sprite Enemyfull;
    public Sprite Enemyempty;


    void Update()
    {
        if (Enemyhealth > Enemyhearts)
        {
            Enemyhealth = Enemyhearts;
        }

        for (int i = 0; i < EnemyheartImg.Length; i++)
        {
            if (i < Enemyhealth)
            {
                EnemyheartImg[i].sprite = Enemyfull;
            }
            else
            {
                EnemyheartImg[i].sprite = Enemyempty;
            }

            if (i < Enemyhearts)
            {
                EnemyheartImg[i].enabled = true;
            }
            else
            {
                EnemyheartImg[i].enabled = false;
            }
        }
    }
}

