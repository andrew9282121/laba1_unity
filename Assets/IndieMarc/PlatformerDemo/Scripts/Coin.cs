using UnityEngine;

public class Coin : MonoBehaviour {
  private void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Player")) {
      if (CoinCounter.instance != null)
        CoinCounter.instance.AddCoin();
      Destroy(gameObject);
    }
  }
}
