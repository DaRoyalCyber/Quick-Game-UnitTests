using NUnit.Framework;
public class GameRulesTests { [Test] public void AddScore_ValidAmount_IncreasesScore() { var game = new GameRules(); game.AddScore(10); Assert.AreEqual(10, game.Score); }
[Test]
public void TakeDamage_ExceedHealth_HealthBecomesZero()
{
    var game = new GameRules();
    game.TakeDamage(150);
    Assert.AreEqual(0, game.Health);
}
}