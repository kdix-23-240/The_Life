using UnityEngine;
using UniRx;

public class BallPresenter : MonoBehaviour
{
    private BallModel _ballModel;
    private BallView _ballView;
    [SerializeField] private float _initialX;
    [SerializeField] private float _initialY;

    void Start()
    {
        Initialize(_ballModel, _ballView);
    }

    public void Initialize(BallModel ballModel, BallView ballView)
    {
        InitializeSetPosition();
        _ballModel = new BallModel(_initialX, _initialY);
        _ballView = this.gameObject.GetComponent<BallView>();
        Debug.Log("BallView:" + _ballView);
        _ballView.Initialize();
        Bind();
    }
    private void Bind()
    {
        _ballModel.BallPosX.Subscribe(x =>
        {
            _ballView.MoveX(x);
        }).AddTo(this);
        _ballModel.BallPosY.Subscribe(y =>
        {
            _ballView.MoveY(y);
        }).AddTo(this);
    }
    private void InitializeSetPosition()
    {
        // ランダムな初期位置を設定
        System.Random random = new System.Random();
        if (random.Next(0, 2) == 0)
        {
            _initialX = -_initialX;
        }
        _initialY += random.Next(0, 4);
    }
}