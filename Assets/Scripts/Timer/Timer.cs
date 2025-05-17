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
        if (GameStateModel.Instance.GameState.Value == GameStateModel.GameStateEnum.Playing)
        {
            _time += Time.deltaTime;
            _timerText.text = "Time: " + _time.ToString("F2");
        }

        if (_time >= _timeLimit)
        {
            GameStateModel.Instance.SetGameState(GameStateModel.GameStateEnum.GameOver);
        }
    }
}