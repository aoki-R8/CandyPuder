using UnityEngine;

public class PlayerCoinManager : MonoBehaviour
{
    // プレイヤーが持っているコイン
    public int playerCoin = 100;

    // コインを1枚投入する
    public void InsertCoin()
    {
        if (playerCoin > 0)
        {
            playerCoin--;

            Debug.Log("コイン投入");
            Debug.Log("残りコイン：" + playerCoin);

            if (playerCoin == 0)
            {
                NoCoin();
            }
        }
    }

    // コインを払い出す
    public void AddCoin(int coin)
    {
        playerCoin += coin;

        Debug.Log("コイン獲得：" + coin);
        Debug.Log("現在のコイン：" + playerCoin);
    }

    // コインが0枚になったとき
    public void NoCoin()
    {
        Debug.Log("コインがありません");
    }
}
