using System;


namespace SharpRPG
{
    public abstract class Tile
    {
        private string name;
        private string description;
        private Coord position;

        public string Name => name;
        public string Description => description;
        public Coord Position => position;
        public Tile(string name, string description, Coord position)
        {
            this.name = name;
            this.description = description;
            this.position = position;
        }
    }
    public abstract class Entity : Tile, IDamagable
    {
        private int health;
        private int damage;
        public Entity(Coord position, string name, string description, int health, int damage) : base(name, description, position)
        {
            this.health = health;
            this.damage = damage;

        }

        public int Health => health;
        public void Attack(IDamagable target)
        {
            Random rand = new Random();
            int damage = rand.Next(0, this.damage);
            target.Damage(damage);
        }
        public void Damage(int damage)
        {
            health -= damage;
            CheckHealth();
        }
        private void CheckHealth()
        {
            if (health <= 0)
            {

            }
        }
    }

    public class Player : Entity
    {
        private BaseItem[] inventory;


        public Player(Coord position) : base(position, "Player", "You.", 10, 1)
        {
            inventory = new BaseItem[10];
        }

    }
    public class Enemy : Entity
    {
        public Enemy(Coord position, string name, string description, int health, int damage) : base (position,name,
            description,health,damage)
        {

        }
    }

    public abstract class BaseItem : Tile
    {
        private int price;
        public BaseItem(string name, string description, Coord position, int price) : base (name, description, position)
        {
            this.price = price;

        }
        public abstract void Use(Entity user);
    }
}
