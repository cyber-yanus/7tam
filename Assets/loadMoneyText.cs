using UnityEngine;
using UnityEngine.UI;

public class loadMoneyText : MonoBehaviour
{
    public PlayerScriptableObject player;

    private Text mobeyText;

    // Start is called before the first frame update
    void Start()
    {
        mobeyText = GetComponent<Text>();

        loadText();
    }

    private void loadText()
    {
        if (player.Money >= 1000)
        {
            int textMoney = player.Money / 1000;

            mobeyText.text = textMoney.ToString() + "K";
        }else
            mobeyText.text = player.Money.ToString();


    }

    private void Update()
    {
        loadText();
    }


}
