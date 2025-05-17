using UnityEngine;
using UniRx;

public class BallPresenter : MonoBehaviour
{
    private BallModel _model;
    private BallView _view;
    [SerializeField] private float _initialX;
    [SerializeField] private float _initialY;

    void Start()
    {
        Initialize(_model, _view);
    }

    /// <summary>
    /// ボールの初期位置を設定し、モデルとビューを初期化する
    /// </summary>
    /// <param name="ballModel"></param>
    /// <param name="ballView"></param>
    public void Initialize(BallModel ballModel, BallView ballView)
    {
        InitializeSetPosition();
        _model = new BallModel(_initialX, _initialY);
        _view = this.gameObject.GetComponent<BallView>();
        _view.Initialize();
        Bind();
    }
    public void Initialize()
    {
        InitializeSetPosition();
        _model = new BallModel(_initialX, _initialY);
        _view = this.gameObject.GetComponent<BallView>();
        _view.Initialize();
        Bind();
    }
    /// <summary>
    /// ボールの位置が変化したときにビューを更新する
    /// </summary>
    private void Bind()
    {
        _model.BallPosX.Subscribe(x =>
        {
            _view.MoveX(x);
        }).AddTo(this);
        _model.BallPosY.Subscribe(y =>
        {
            _view.MoveY(y);
        }).AddTo(this);
    }
    /// <summary>
    /// ボールの初期位置を設定する
    /// この時、x座標時は左右どちらかに生成されるようにランダムで決定
    /// y座標は初回の反射時の反発力に差をつけるためにランダムで決定
    /// </summary>
    private void InitializeSetPosition()
    {
        System.Random random = new System.Random();// 右か左かを決める2値の乱数
        //  0なら左、1なら右　
        if (random.Next(0, 2) == 0)
        {
            _initialX = -_initialX;
        }
        // -1~5の乱数を生成
        _initialY = Random.Range(-1f, 5f);
    }
}