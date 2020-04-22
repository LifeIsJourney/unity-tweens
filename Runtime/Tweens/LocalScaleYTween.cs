using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalScaleYTween : Tween<float> {
    private Vector3 localScale;

    public override float OnGetFrom () {
      return this.transform.localScale.y;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localScale = this.transform.localScale;
      this.valueCurrent = Mathf.Lerp (this.valueFrom, this.valueTo, easedTime);
      this.localScale.y = this.valueCurrent;
      this.transform.localScale = this.localScale;
    }
  }
}