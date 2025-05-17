using UniRx;

public class StageModel
{
    private readonly ReactiveProperty<float> _stagePosX;// ステージのX座標
    public ReactiveProperty<float> StagePosX;
    private float _speed; // ステージの移動量
    private float _maxPosX; // ステージの最大X座標
    public float StagePosXValue
    {
        get => StagePosX.Value;
        set => StagePosX.Value = value;
    }
    public StageModel(float speed, float maxPos)
    {
        _speed = speed;
        _maxPosX = maxPos;
        _stagePosX = new ReactiveProperty<float>(0f);
        StagePosX = _stagePosX;
    }
    public void SetStagePosX(float x)
    {
        StagePosX.Value = x;
    }
    public void MoveRight()
    {
        if(StagePosX.Value < _maxPosX)
        {
            StagePosX.Value += _speed;
        }
    }
    public void MoveLeft()
    {
        if(StagePosX.Value > -_maxPosX)
        {
            StagePosX.Value -= _speed;
        }
    }
}