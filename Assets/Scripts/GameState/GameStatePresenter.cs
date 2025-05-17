using UnityEngine;
using UniRx;

public class GameStatePresenter : MonoBehaviour
{
    private GameStateModel _model;
    [SerializeField] private GameStartStateView _startView;
    [SerializeField] private GameResultView _resultView;

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
                    _resultView.Show();
                    break;
            }
        }).AddTo(this);
    }
}