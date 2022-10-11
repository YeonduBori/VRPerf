
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace VowganVR
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class InsightDirectedExample : UdonSharpBehaviour
    {
        
        public bool BlendCamera;
        public bool LockPlayer = true;
        public float Duration = 3;
        public InsightController Controller;
        public Transform Target;
        public Transform LookAt;
        
        private bool directing;
        
        
        public override void Interact()
        {
            if (directing) return;
            directing = true;
            Controller.StartDirection(Target, LookAt, BlendCamera, LockPlayer);
            SendCustomEventDelayedSeconds(nameof(EndDirection), Duration);
        }
        
        public void EndDirection()
        {
            directing = false;
            Controller.EndDirection(LockPlayer);
        }
        
        
    }
}