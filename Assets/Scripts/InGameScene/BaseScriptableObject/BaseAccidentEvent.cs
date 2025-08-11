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
}
