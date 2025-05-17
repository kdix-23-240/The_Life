using UniRx;

public class BallModel
{
    private readonly ReactiveProperty<float> _ballPosX;
    public ReactiveProperty<float> BallPosX;
    private readonly ReactiveProperty<float> _ballPosY;
    public ReactiveProperty<float> BallPosY;

    public BallModel(float initialX, float initialY)
    {
        _ballPosX = new ReactiveProperty<float>(initialX);
        BallPosX = _ballPosX;
        _ballPosY = new ReactiveProperty<float>(initialY);
        BallPosY = _ballPosY;
    }
}