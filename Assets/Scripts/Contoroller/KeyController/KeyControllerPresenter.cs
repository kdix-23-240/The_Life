using UnityEngine;
using UniRx;

/// <summary>
/// キーボード入力による操作を行うクラス
/// </summary>
public class KeyController : MonoBehaviour, IController
{
    private KeyControllerModel _keyControllerModel;
    [SerializeField] private StageModel _stageModel;

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
        Control();
    }
    /// <summary>
    /// キーボード入力による操作を行う
    /// </summary>
    public void Control()
    {
        // 左右の移動
        // 左端にいなければ、移動できる
        if (Input.GetKey(KeyCode.A))
        {
            _keyControllerModel.AButtonPressed.Value = true;
        }
        else
        {
            _keyControllerModel.AButtonPressed.Value = false;
        }

        // 右に移動
        // 右端にいなければ、移動できる
        if (Input.GetKey(KeyCode.D))
        {
            _keyControllerModel.DButtonPressed.Value = true;
        }
        else
        {
            _keyControllerModel.DButtonPressed.Value = false;
        }
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
}