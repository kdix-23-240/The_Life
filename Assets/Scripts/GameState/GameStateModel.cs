using UniRx;

/// <summary>
/// シングルトンでゲームの状態を管理するクラス
/// </summary>
public class GameStateModel
{
    // シングルトンインスタンス
    private static GameStateModel _instance;
    public static GameStateModel Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameStateModel();
            }
            return _instance;
        }
    }

    public enum GameStateEnum
    {
        Start,
        Playing,
        GameOver
    }

    private ReactiveProperty<GameStateEnum> _gameState = new ReactiveProperty<GameStateEnum>(GameStateEnum.Start);

    public IReadOnlyReactiveProperty<GameStateEnum> GameState => _gameState;

    public void ChangeGameState(GameStateEnum state)
    {
        _gameState.Value = state;
    }
    // コンストラクタをprivateにして外部からの生成を禁止
    private GameStateModel() { }
    public void SetGameState(GameStateEnum state)
    {
        _gameState.Value = state;
    }
    public GameStateEnum GetGameState()
    {
        return _gameState.Value;
    }
}