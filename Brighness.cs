using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing; 


public class Brighness : MonoBehaviour
{
 
  public void Start (){

         
    }

    public void SetBrightness (float brightness)
    {
         
         var pv = GetComponent<PostProcessVolume>();
         pv.profile.GetSetting<ColorGrading>().gamma.value = new Vector4(0, 0, 0, brightness);

    }
    

    
}
