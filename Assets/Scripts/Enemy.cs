using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public int maxHp = 2;
    public int hp = 2;
    public TextMeshProUGUI hpText;
    public StageOut stageout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject AttackButton = GameObject.Find("Attack");
        AttackButton.GetComponent<Button>().onClick.AddListener(OnReceiveAttacked);

                // 1. ヒエラルキーの "HPText" という名前のテキストを自動割り当て
        if (hpText == null)
        {
            GameObject textObj = GameObject.Find("HPText");
            if (textObj != null)
            {
                hpText = textObj.GetComponent<TextMeshProUGUI>();
            }
        }
        // 2. StageOut を自動割り当て
        if (stageout == null)
        {
            stageout = FindAnyObjectByType<StageOut>();
        }

        UpdateHPUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReceiveAttacked()
    {
        if (hp <= 0) return;

        if (stageout != null && stageout.SCORE <= 0) return;

        if (stageout != null)
        {
            stageout.SCORE -= 1;
            stageout.SCOREText.text = $"{stageout.SCORE}";
        }


        hp += -1;
        UpdateHPUI();

        if (hp <= 0)
        {
            Defeat();
        }

    }

    public void UpdateHPUI()
    {
        hpText.text = $"HP: {hp}";
    }

    void Defeat()
    {
        stageout.SCORE *= 2;
        stageout.SCOREText.text = $"{stageout.SCORE}";

        Destroy(gameObject);
    }
}
