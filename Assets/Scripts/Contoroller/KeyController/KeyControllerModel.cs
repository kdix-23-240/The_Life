using UniRx;

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