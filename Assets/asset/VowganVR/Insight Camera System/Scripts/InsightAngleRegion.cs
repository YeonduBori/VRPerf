
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace VowganVR
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class InsightAngleRegion : UdonSharpBehaviour
    {
        
        public bool BlendCamera;
        public InsightController Controller;
        public Transform Target;
        public Transform LookAt;
        
        private bool directing;
        
        
        public override void OnPlayerTriggerEnter(VRCPlayerApi player)
        {
            if (!player.isLocal) return;
            if (directing) return;
            directing = true;
            Controller.StartDirection(Target, LookAt, BlendCamera, false);
        }
        
        public override void OnPlayerTriggerExit(VRCPlayerApi player)
        {
            if (!player.isLocal) return;
            directing = false;
            Controller.EndDirection(false);
        }
    }
}