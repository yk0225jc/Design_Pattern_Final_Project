using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTest
{
    protected Vector3 playerStartPosition;
    protected Vector3 zombieStartPosition;
    protected Vector3 slugStartPosition;
    protected GameObject player;
    protected GameObject zombie;
    protected GameObject slug;

    [Test]
    public void CanFindPlayer()
    {
        player = GameObject.Find("ThirdPersonController");
        Assert.NotNull(player);
    }

    [Test]
    public void CanFindZombie()
    {
        zombie = GameObject.Find("Zombie");
        Assert.NotNull(zombie);
    }

    [Test]
    public void CanFindSlug()
    {
        slug = GameObject.Find("Slug");
        Assert.NotNull(slug);
    }

    [Test]
    public void ExactPlayerStartPosition()
    {
        playerStartPosition = player.transform.position;
        Assert.AreEqual(playerStartPosition, new Vector3(3.68f, 3.23f, -81.6f));
    }

    [Test]
    public void ExactZombieStartPosition()
    {
        zombieStartPosition = zombie.transform.position;
        Assert.AreEqual(zombieStartPosition, new Vector3(-3.63f, 4.06f, 3.8f));
    }

    [Test]
    public void ExactSlugStartPosition()
    {
        slugStartPosition = slug.transform.position;
        Assert.AreEqual(slugStartPosition, new Vector3(-0.5958414f, 3.41f, 2.78f));
    }

}
