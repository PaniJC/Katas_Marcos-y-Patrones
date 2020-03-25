class MarioAdapter {
  constructor(mInstance) {
    this.mInstance = mInstance;
  }

  attack(target) {
    target.health -= this.mInstance.jumpAttack();
  }
}