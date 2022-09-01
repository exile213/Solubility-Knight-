using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDMGS: MonoBehaviour
{
  
    public void PLDMG()
    {
 
        StartCoroutine(DMGPL());
    

    }

    IEnumerator DMGPL()
    {
        yield return new WaitForSeconds(1);
        PlayerHeart PLHP = GetComponent<PlayerHeart>();
     
        PLHP.PLhealth -= 1;

        if (PLHP.PLhealth == 0)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("Lose Scene");
        }
    }
    
}
