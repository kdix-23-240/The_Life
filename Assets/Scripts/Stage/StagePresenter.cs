using UnityEngine;
using UniRx;

public class StagePresenter : MonoBehaviour
{
    private StageModel _model;
    private StageView _view;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _maxPosX = 4.3f;

    void Awake()
    {
        _model = new StageModel(_moveSpeed, _maxPosX);
        _view = GetComponent<StageView>();
    }
    void Start()
    {
        _view.Initialize();
        Bind();
    }
    void Update()
    {

    }
    private void Move(float x)
    {
        _model.StagePosX.Value += x;
    }
    private void Bind()
    {
        _model.StagePosX.Subscribe(x =>
        {
            _view.Move(x);
        }).AddTo(this);
    }

    public StageModel GetStageModel()
    {
        return _model;
    }
}