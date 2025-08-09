using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class EventManagerPlayableAsset : PlayableAsset
{
    [SerializeField] AccidentEvent[] _accidentEvents;
    // Factory method that generates a playable based on this asset
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        EventManagerPlayableBehaviour eventManagerPlayableBehaiour = new EventManagerPlayableBehaviour();
        return ScriptPlayable<EventManagerPlayableBehaviour>.Create(graph, eventManagerPlayableBehaiour);
    }
}
