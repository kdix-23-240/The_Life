using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// ボールを生成するクラス
/// </summary>
public class BallCreator : PoolManager<BallPool>
{
    [SerializeField] private Sprite[] _ballSprites;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _createDelayTime = 5f;// 生成間隔(秒)

    async UniTask Start()
    {
        Initialize();
        while (true)
        {
            Create();
            // _createDelayTime 秒の遅延
            await UniTask.Delay((int)(_createDelayTime * 1000));
        }
    }
    /// <summary>
    /// ボールを生成する
    /// </summary>
    private void Create()
    {
        var ballObj = _objectPool.Get();
        var spriteRenderer = ballObj.transform.GetChild(1).GetComponent<SpriteRenderer>();
        SelectRandomSprite(spriteRenderer);
        ballObj.GetComponent<BallPresenter>().Initialize();
        ballObj.Initialize();
    }

    private void SelectRandomSprite(SpriteRenderer spriteRenderer)
    {
        int randomIndex = Random.Range(0, _ballSprites.Length);
        spriteRenderer.sprite = _ballSprites[randomIndex];
    }
}