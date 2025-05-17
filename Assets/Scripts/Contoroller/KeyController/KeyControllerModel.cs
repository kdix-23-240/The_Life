using UniRx;

/// <summary>
/// キーボード入力による操作を行うクラス
/// AボタンとDボタンが押されているかどうかを管理する
/// </summary>
public class KeyControllerModel
{
    private readonly ReactiveProperty<bool> _aButtonPressed;
    public ReactiveProperty<bool> AButtonPressed => _aButtonPressed;
    private readonly ReactiveProperty<bool> _dButtonPressed;
    public ReactiveProperty<bool> DButtonPressed => _dButtonPressed;

    public KeyControllerModel()
    {
        _aButtonPressed = new ReactiveProperty<bool>(false);
        _dButtonPressed = new ReactiveProperty<bool>(false);
    }
}