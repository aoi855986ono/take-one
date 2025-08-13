using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableObject", menuName = "AccidentEvent")]
public class AccidentEvent : ScriptableObject
{
    [Header("アクシデントのパラメータを設定してください")]
    [Tooltip("確率")] public int Rate;
    [Tooltip("評価値")] public float AssessmentScore;
    [Tooltip("アクシデントネーム")] public string AccidentName;

    [Header("ログに表示される項目")] 
    [Tooltip("発生時間")] [Range(0, 59)] public int GenerateTime;
    [Tooltip("何をするか")] public string ToDo;
    [Tooltip("NPC名")] public string NPCName;
    [Tooltip("解決方法")] public string Solution;
}
