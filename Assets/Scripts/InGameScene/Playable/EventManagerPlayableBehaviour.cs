using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Playables;

// A behaviour that is attached to a playable
public class EventManagerPlayableBehaviour : PlayableBehaviour
{
    public AccidentEvent[] AccidentEvents;
    List<int> _accidentEventsRate = new List<int>();
    
    CinematographyLogComponent _cinematographyLogComponent;
    
    // Called when the owning graph starts playing 所有するグラフが再生を開始したときに呼び出される
    public override void OnGraphStart(Playable playable)
    {
        DesideAccident(); //①
        CinematographyLog(); //②
    }

    // Called when the owning graph stops playing 所有するグラフが再生を停止したときに呼び出される
    public override void OnGraphStop(Playable playable)
    {
        
    }

    // Called when the state of the playable is set to Play playableの状態がPlayに設定されたときに呼び出される
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
        
    }

    // Called when the state of the playable is set to Paused playableの状態がPausedに設定されたときに呼び出される
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        
    }

    // Called each frame while the state is set to Play 状態がPlayに設定されている間、毎フレーム呼び出される
    public override void PrepareFrame(Playable playable, FrameData info)
    {
        
    }
    /// <summary>
    /// ① サイコロをふってアクシデントを決定する
    /// </summary>
    void DesideAccident()
    {
        //サイコロを振って決められるようにアクシデントの中にある確率の値を調整する。サイコロの最大値を決定する。
        int diceMaxNunber = 0;
        foreach (var accidentEvent in AccidentEvents)
        {
            diceMaxNunber += accidentEvent.Rate;
            _accidentEventsRate.Add(diceMaxNunber);
        }
        //サイコロを振って出目を確定。
        int dice = UnityEngine.Random.Range(1, diceMaxNunber + 1);
        //出目に該当するアクシデントを検索する。
        int index = _accidentEventsRate.FindIndex(rate => dice <= rate);
        AccidentEvent decideAccidentEvent = AccidentEvents[index];
        Debug.Log($"ダイスの目{dice}によって選ばれたアクシデントは{decideAccidentEvent.name}（{_accidentEventsRate[index]}）");
    }
    /// <summary>
    /// ②　CinematographyLogの内容を更新する
    /// </summary>
    void CinematographyLog() //デリゲートで呼び出したいな…… → Interfaceを実装するなら → 同じInterfaceを実装させて、その中の関数を発動させれば良いのか？？ → Logの方に受信メソッドを書き、Log.受信メソッド をこのクラスに登録させれば良い → この登録がそもそもめんどい → new Class名でインスタンスさせればよいか → イケそう
    {
        _cinematographyLogComponent = GameObject.Find("(I)CinematographyLog").GetComponent<CinematographyLogComponent>();
        string[] texts = new string[]{"hoge"};
        //ここでAccidentEventの情報を渡せるようにしたい
        _cinematographyLogComponent.UpdateCinematographyLog(texts);
    }
}
