using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class wre : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinsText;
    
 
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "coin")
        {
            coins+=100;
            PlayerPrefs.SetInt("coin", coins);
            coinsText.text = coins.ToString();
            Destroy(coll.gameObject);
        }
    }
}
