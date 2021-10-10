using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curranceyPickUp : MonoBehaviour
{
    public int worth = 100;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            Destroy(gameObject);
            LevelManager.instance.IncreaseCurrancey(worth);
        }
    }
}
