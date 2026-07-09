using UnityEngine;
using UnityEngine.UI;
using System;

public class StageOut : MonoBehaviour
{
    public int SCORE = 0 ;

    public Text SCOREText;
    // 来週の頭(一限)に適当に選んだ3人を当てる予定
    // 要件定義：StageOutクラスの中に変数 Scoreを作成、オブジェクトがすり抜けたらScoreを1加算する
    // 1. StageOutクラスの中に変数 Scoreを作成
    // 2. 変数 Score は int型 かつ private であること
    // 3. オブジェクトがすり抜けたら(OnTriggerEnterが呼ばれたら)変数 Scoreに1を加算する
    // 4. 加算後の変数 ScoreをDebug.Logでコンソール上に出力する

    // このコードがアタッチされているオブジェクトのisTrigger(コライダー設定)が有効
    // かつ他のオブジェクトがすり抜けた時に中の処理を行うイベント関数

    public AudioManager audiomanager;

    void OnTriggerEnter(Collider other)
    {
        audiomanager.PlaySE();

        SCORE += 1;
        Debug.Log($"SCORE: {SCORE}");
        SCOREText.text = ($"SCORE:{SCORE}");
        // 変数名 otherってなに？
        // A.すり抜けた相手のコライダー情報
        Debug.Log($"{other.name}がすり抜けました。");
        // Destroy関数
        // Destroy(破棄したいオブジェクト)
        // オブジェクトが使用しているメモリの解放(ガベージコレクション)と描画情報の破棄
        Destroy(other.gameObject);
    }
   
}
