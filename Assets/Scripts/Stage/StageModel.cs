using UniRx;

public class StageModel
{
    private readonly ReactiveProperty<float> _stagePosX;
    public ReactiveProperty<float> StagePosX;
    // StagePosXのValueを取得するプロパティ
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