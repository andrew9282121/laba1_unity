using UnityEngine;

public class Spikes : MonoBehaviour {
  private void OnCollisionEnter2D(Collision2D collision) {
    if (collision.gameObject.CompareTag("Player")) {
      collision.gameObject.transform.position = new Vector3(-6f, 0f, 0f);
    }
  }
}
