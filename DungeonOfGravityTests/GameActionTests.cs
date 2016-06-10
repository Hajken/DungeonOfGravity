
using NUnit.Framework;
using DungeonOfGravity.GameActions;
using DungeonOfGravity.Creatures;
using System.Collections.Generic;
using DungeonOfGravity.Items;

namespace DungeonOfGravityTests
{
    public class GameActionTests
    {
        [Test]
        public void CreatePlayerTest()
        {
            var playerAction = new PlayerAction();
            var player = playerAction.CreatePlayer("Test");
            
            Assert.That(player.Name, Is.EqualTo("Test"));
            Assert.That(player.Experience, Is.EqualTo(0));
            Assert.That(player.Strength, Is.EqualTo(10));
            Assert.That(player.Agility, Is.EqualTo(10));
            Assert.That(player.Distance, Is.EqualTo(10));
            Assert.That(player.Magic, Is.EqualTo(0));
            Assert.That(player.Energy, Is.EqualTo(0));
            Assert.That(player.Level, Is.EqualTo(1));
            Assert.That(player.Health, Is.EqualTo(100));
            Assert.That(player.IsDead, Is.EqualTo(false));
        }


    }
}
