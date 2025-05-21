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
















///
/// 1. ボタンがトリガー
///     ボタンを押す → それをトリガーに処理を行う
/// 
/// 
/// 
/// 
/// 
/// 2. static変数を経由
///     ボタンを押す　→ static bool値をtrueにする → それをトリガーに処理を行う
/// 
/// 
/// 
/// 
/// 
///
/// 3. Observerパターン
///     ボタンを押す(Presenter)　→ ModelのReactivePropertyの値をtrueにする 
///    → それをPresenterで監視する　→ どのクラスのどんな処理でも呼び出すことができる


















