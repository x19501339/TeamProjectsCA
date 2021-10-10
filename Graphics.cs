using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphics : MonoBehaviour
{
   
public void SetQulity (int qualityIndex)
{

    QualitySettings.SetQualityLevel(qualityIndex);

}


}
