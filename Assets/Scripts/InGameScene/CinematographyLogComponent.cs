using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CinematographyLogComponent : MonoBehaviour
{
    [SerializeField] GameObject _cinematographyLogPrefab;
    GameObject _cinematographyLogObject;

    private void Start()
    {
        _cinematographyLogObject = gameObject;
    }

    public void UpdateCinematographyLog(string[] logTexts)
    {
        //CinematographyLogPrefabを生成する
        GameObject currentCinematographyLogObject = Instantiate(_cinematographyLogPrefab, _cinematographyLogObject.transform);
        string text = "";
        foreach (string logText in logTexts)
        {
            text += logText + "\t";
        }
        currentCinematographyLogObject.GetComponent<TextMeshProUGUI>().text = text;
    }
}
