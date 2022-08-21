using System;

namespace FrameworkDesign
{
    public class Event<T> where T:Event<T>    //�޶�ֻ���Ǽ̳��Լ�
    {
        public static Action mOnAction;

        /// <summary>
        /// ע���¼�
        /// </summary>
        /// <param name="onAction"></param>
        public static void RegisterEvent(Action onAction)
        {
            mOnAction += onAction;
        }
        /// <summary>
        /// ע���¼�
        /// </summary>
        /// <param name="onAction"></param>
        public static void UnRegisterEvent(Action onAction)
        {
            mOnAction -= onAction;
        }

        /// <summary>
        /// �����¼�
        /// </summary>
        public static void Tigger()
        {
            mOnAction?.Invoke();
        }
    }

}
