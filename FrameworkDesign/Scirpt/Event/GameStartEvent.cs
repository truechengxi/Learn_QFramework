using System;
using UnityEngine;


namespace FrameworkDesign.Example
{
    //注意静态类不能继承
    public   class GameStartEvent :Event<GameStartEvent>
    {

    }

}
