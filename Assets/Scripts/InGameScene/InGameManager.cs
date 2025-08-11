using System.Collections;
using System.Collections.Generic;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SocialPlatforms.Impl;

public class InGameManager : MonoBehaviour
{
    [SerializeField] PlayableDirector _playableDirector;
    RecorderController  _recorderController;
    float _totalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// Recorderの初期化・セットアップ
    /// </summary>
    void SetUpRecorder()
    {
        int outputWidth = 1080;
        int outputHeight = 1920;
        RecorderControllerSettings recorderControllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        _recorderController = new RecorderController(recorderControllerSettings);
        recorderControllerSettings.SetRecordModeToManual();
        recorderControllerSettings.FrameRate = 60;
        recorderControllerSettings.CapFrameRate = true;
        MovieRecorderSettings movieRecorderSettings = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        movieRecorderSettings.name = "MovieRecorder";
        movieRecorderSettings.OutputFile = ("Recorder_TAKE ONE_.mp4");
        var encordingSettings = movieRecorderSettings.EncoderSettings; //怪しいコード
        movieRecorderSettings.ImageInputSettings = new CameraInputSettings()
        {
            Source = ImageSource.MainCamera,
            OutputWidth = outputWidth,
            OutputHeight = outputHeight,
            CaptureUI = true
        };//途中です
    }
    
    /// <summary>
    /// 三浦用
    /// </summary>
    void RecordManual()
    {
        //これが録画開始処理
        _recorderController.StartRecording();
        //これが録画停止処理
        _recorderController.StopRecording();
    }


}
