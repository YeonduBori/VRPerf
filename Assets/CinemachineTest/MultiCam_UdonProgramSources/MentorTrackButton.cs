
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MentorTrackButton : UdonSharpBehaviour
{
    public UdonBehaviour trackerController;

    public override void Interact()
    {
        base.Interact();
        trackerController.SendCustomEvent("MentorFace");
    }
}
