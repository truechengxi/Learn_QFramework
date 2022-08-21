using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{

    public class GameManager : MonoBehaviour
    {

        private void Awake()
        {
            GameStartEvent.RegisterEvent(OnGameStartEvent);

            KillOneEnemyEvent.RegisterEvent(OnKillEnemyEvent);
        }

        private void OnKillEnemyEvent()
        {
            GameModel.KillCount++;
            if (GameModel.KillCount>=10)
            {
                GamePassEvent.Tigger();
            }
        }

        private void OnGameStartEvent()
        {
            transform.Find("Enemis").gameObject.SetActive(true);

        }

        private void OnDestroy()
        {
            GameStartEvent.UnRegisterEvent(OnGameStartEvent);
            KillOneEnemyEvent.UnRegisterEvent(OnKillEnemyEvent);
        }
    }

}
