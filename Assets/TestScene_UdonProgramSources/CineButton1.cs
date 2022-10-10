
using UdonSharp;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using VRC.SDKBase;
using VRC.Udon;

public class CineButton1 : UdonSharpBehaviour
{
    public PlayableDirector director;

    void Start()
    {

    }

    public override void Interact()
    {
        Debug.Log("CineButton1");
    }

}
