using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CoinCharge : MonoBehaviour
{

    public CreateCandy createCandy;
    public StageOut stageout;
    public UnityEvent onClickCoin;
    public UnityEvent onClickEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnReceiveAttack()
    {
    
        int number = stageout.SCORE;
        if (number > 0)
        {
            // シーン内にいる Enemy を自動で探す
            Enemy currentEnemy = FindAnyObjectByType<Enemy>();
            // 敵がいたら攻撃を届ける！
            if (currentEnemy != null)
            {
                currentEnemy.OnReceiveAttacked();
            }
        
    }
}
}
