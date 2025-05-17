using UnityEngine;
using UniRx;

public class GameStatePresenter : MonoBehaviour
{
    private GameStateModel _model;
    private GameStartStateView _startView;
    private GameResultView _resultView;

    void Awake()
    {
        _model = GameStateModel.Instance;
        _startView = this.gameObject.GetComponent<GameStartStateView>();
        _resultView = this.gameObject.GetComponent<GameResultView>();
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