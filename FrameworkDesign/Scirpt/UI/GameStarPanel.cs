using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    public class GameStarPanel : MonoBehaviour
    {
        private Button btn_stat;


        private void Start()
        {
            btn_stat=transform.Find("Btn_start").GetComponent<Button>();
            btn_stat.onClick.AddListener(() =>
            {
                transform.gameObject.SetActive(false);
                GameStartEvent.Tigger();    //发送一个事件
            });
        }


    }

}
