using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDMGS : MonoBehaviour
{
    public void ENDMG()
    {

        StartCoroutine(DMGEN());


    }

    IEnumerator DMGEN()
    {
        yield return new WaitForSeconds(1);
        EnemyHeart ENHP = GetComponent<EnemyHeart>();
        ENHP.Enemyhealth -= 1;

        if (ENHP.Enemyhealth == 0)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("Win Scene");
        }
    }

}
