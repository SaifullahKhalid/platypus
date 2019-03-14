using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health {

    bool isShielded;

    float shieldTime;

    private void Start()
    {
        GiveShield(2);
    }

    public override void ChangeHealth(int changeAmt)
    {
        if (!isShielded)
        {
            Debug.Log(changeAmt + " damage given");
            base.ChangeHealth(changeAmt);
            if (gameObject.activeInHierarchy)
            {
                GiveShield(2);
            }
            else {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
            
        }else
            Debug.Log(changeAmt+ " damage rnot recived,, shidld");
    }
    
    public void GiveShield(float time)
    {
        isShielded = true;
        shieldTime = time;
        StartCoroutine(ShieldConsume());
    }

    private IEnumerator ShieldConsume() {
        while(shieldTime > 0)
        {
            shieldTime -= Time.deltaTime;
            isShielded = false;
            yield return null;
        }
    }

}
