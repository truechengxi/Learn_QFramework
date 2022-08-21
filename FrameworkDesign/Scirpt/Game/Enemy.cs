using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour
    {


        private void OnMouseDown()
        {
            KillOneEnemyEvent.Tigger();
            Destroy(gameObject);
        }
    }
}
    

