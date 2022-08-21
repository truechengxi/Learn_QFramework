using FrameworkDesign.Example;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private void Awake()
    {
        GamePassEvent.RegisterEvent(OnGamePaseEvent);
    }

    private void OnGamePaseEvent()
    {
        transform.Find("Canvas").transform.Find("GameStatPanel (1)").gameObject.SetActive(true); 
    }


    private void OnDisable()
    {
        GamePassEvent.UnRegisterEvent(OnGamePaseEvent);
    }
}
