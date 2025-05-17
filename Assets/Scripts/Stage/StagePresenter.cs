using UnityEngine;
using UniRx;

public class StagePresenter : MonoBehaviour
{
    private StageModel _model;
    private StageView _view;
    private IController _controller;

    void Awake()
    {
        _model = new StageModel();
        _view = GetComponent<StageView>();
        _controller = GetComponent<IController>();
    }
    void Start()
    {
        _view.Initialize();
        Bind();
    }
    void Update()
    {
        _controller.Control();
    }
    private void Move(float x)
    {
        _model.StagePosX.Value += x;
    }
    private void Bind()
    {
        _model.StagePosX.Subscribe(x =>
        {
            Debug.Log("バインドx:" + x);
            _view.Move(x);
        }).AddTo(this);
    }
}