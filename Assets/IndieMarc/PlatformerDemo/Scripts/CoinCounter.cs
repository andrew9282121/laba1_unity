using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {
  public static CoinCounter Instance;

  public Text coinText;

  private int coins = 0;

  void Awake() {
    if (Instance == null)
      Instance = this;
    else
      Destroy(gameObject);
  }

  void Start() {
    UpdateUI();
  }

  public void AddCoin(int amount = 1) {
    coins += amount;
    UpdateUI();
  }

  private void UpdateUI() {
    coinText.text = "Монеты: " + coins;
  }
}
