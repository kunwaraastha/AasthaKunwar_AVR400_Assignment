using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinData : MonoBehaviour
{
    public gamemanagerScript gamemanagerscript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamemanagerscript.coinAdd();
            Destroy(gameObject);
        }
    }
}