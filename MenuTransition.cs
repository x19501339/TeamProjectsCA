using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour
{

    public void switchToScene(int sceneIndex){

        SceneManager.LoadScene(sceneIndex);

    }

}

