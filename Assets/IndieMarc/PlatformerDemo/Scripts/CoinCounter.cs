using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour {
  public static CoinCounter instance;
  public TextMeshProUGUI coinText;
  private int coins = 0;

  void Awake() {
    instance = this;
    UpdateText();
  }

  public void AddCoin() {
    coins++;
    UpdateText();
  }

  void UpdateText() {
    if (coinText != null)
      coinText.text = "Монеты: " + coins;
    else
      Debug.LogError("coinText is NULL!");
  }
}
