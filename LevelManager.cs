using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour{
    public static LevelManager instance;
    public Transform respawnPoint;
    public GameObject playerPrefab;
    public CinemachineVirtualCameraBase cam;

   public int currency = 0;

    private void Awake(){
        instance = this;
    }
    public void Respawn (){
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;

    }

    public void IncreaseCurrancey(int amount){
        currency += amount;
    }
}
