using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class l11 : MonoBehaviour
{





    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Finish")
        {
            SceneManager.LoadScene(11);
        }
    }
}
