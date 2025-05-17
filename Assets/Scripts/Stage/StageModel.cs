using UniRx;

public class StageModel
{
    private readonly ReactiveProperty<float> _stagePosX;// ステージのX座標
    public ReactiveProperty<float> StagePosX;
    public float StagePosXValue
    {
        get => StagePosX.Value;
        set => StagePosX.Value = value;
    }
    public StageModel()
    {
        _stagePosX = new ReactiveProperty<float>(0f);
        StagePosX = _stagePosX;
    }
}