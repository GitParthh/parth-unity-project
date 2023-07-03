using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollesion : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerManaer.isGameOver = true;
            gameObject.SetActive (false); 
        }
    }
}
