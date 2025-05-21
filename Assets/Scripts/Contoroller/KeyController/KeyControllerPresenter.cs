using UnityEngine;
using UniRx;

/// <summary>
/// キーボード入力による操作を行うクラス
/// </summary>
public class KeyControllerPresenter : MonoBehaviour
{
    private KeyControllerModel _keyControllerModel;
    private StageModel _stageModel;

    void Awake()
    {
        _keyControllerModel = new KeyControllerModel();
    }
    void Start()
    {
        _stageModel = GetComponent<StagePresenter>().GetStageModel();
        Bind();
    }
    void Update()
    {

    }
    public void Bind()
    {
        // Aボタンが押されたときの処理
        _keyControllerModel.AButtonPressed.Subscribe(isPressed =>
        {
            if (isPressed)
            {
                _stageModel.MoveLeft();
            }
        }).AddTo(this);

        // Dボタンが押されたときの処理
        _keyControllerModel.DButtonPressed.Subscribe(isPressed =>
        {
            if (isPressed)
            {
                _stageModel.MoveRight();
            }
        }).AddTo(this);
    }

    public KeyControllerModel GetKeyControllerModel()
    {
        return _keyControllerModel;
    }
}