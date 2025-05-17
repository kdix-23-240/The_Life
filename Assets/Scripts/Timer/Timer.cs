using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private int _timeLimit = 60;
    private float _time;
    void Start()
    {
        _time = 0f;
        _timerText.text = "Time: 0.00";
    }
    void Update()
    {
        // ゲームの状態がPlayingの時だけタイマーを動かす
        if (GameStateModel.Instance.GameState.Value == GameStateModel.GameStateEnum.Playing)
        {
            _time += Time.deltaTime;
            _timerText.text = "Time: " + _time.ToString("F2");
        }
        // タイマーが時間制限を超えたらゲームオーバーにする
        if (_time >= _timeLimit)
        {
            _time = 0f;
            GameStateModel.Instance.SetGameState(GameStateModel.GameStateEnum.GameOver);
        }
    }
}