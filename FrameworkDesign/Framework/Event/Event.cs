using System;

namespace FrameworkDesign
{
    public class Event<T> where T:Event<T>    //限定只能是继承自己
    {
        public static Action mOnAction;

        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="onAction"></param>
        public static void RegisterEvent(Action onAction)
        {
            mOnAction += onAction;
        }
        /// <summary>
        /// 注销事件
        /// </summary>
        /// <param name="onAction"></param>
        public static void UnRegisterEvent(Action onAction)
        {
            mOnAction -= onAction;
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void Tigger()
        {
            mOnAction?.Invoke();
        }
    }

}
