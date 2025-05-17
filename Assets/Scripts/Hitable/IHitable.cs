using UnityEngine;
public interface IHitable
{
    /// <summary>
    /// 当たり判定を持つオブジェクトのインターフェース
    /// </summary>
    /// <param name="hitPos">当たった位置</param>
    void Hit(Collider2D other);
}