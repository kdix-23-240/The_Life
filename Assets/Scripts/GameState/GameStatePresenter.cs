using UnityEngine;
using UniRx;

public class GameStatePresenter : MonoBehaviour
{
    private GameStateModel _model;
    [SerializeField] private GameStartStateView _startView;
    [SerializeField] private GameResultView _resultView;
    [SerializeField] private GameObject _creator;
    private float _timer;

    void Awake()
    {
        _model = GameStateModel.Instance;
    }
    void Start()
    {
        _startView.Initialize();
        _resultView.Initialize();
        Bind();
    }
    /// <summary>
    /// ゲームの状態が変化したらポップアップを更新する
    /// </summary>
    private void Bind()
    {
        _model.GameState.Subscribe(state =>
        {
            switch (state)
            {
                case GameStateModel.GameStateEnum.Start:
                    _startView.Show();
                    _resultView.Hide();
                    break;
                case GameStateModel.GameStateEnum.Playing:
                    _startView.Hide();
                    _resultView.Hide();
                    break;
                case GameStateModel.GameStateEnum.GameOver:
                    _startView.Hide();
                    for (int i = _creator.transform.childCount - 1; i >= 0; i--)
                    {
                        Destroy(_creator.transform.GetChild(i).gameObject);
                    }
                    _resultView.Finish(BallCreator.BallCount - GameOver.DiedNum, GameOver.DiedNum);
                    break;
            }
        }).AddTo(this);
    }
}