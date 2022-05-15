using System.Timers;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    float _interval = 5f;
    float _time=0f;
    int counter=0;

    void Start(){
         CameraOne();
    }
    
    void Update(){
        
        _time+=Time.deltaTime;
       while(_time >= _interval) {
           if (counter==1){
     CameraTwo();
           }
            else{
     CameraOne();
           }
      _time -= _interval;
    }
        
        
    }

    public int CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
       return counter=1;
        
    }

    public int CameraTwo()
    {
        
        Camera2.SetActive(true);
        Camera1.SetActive(false);  
        return counter=0;
    }



}