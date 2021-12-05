namespace SharpRPG
{
    public interface IDamagable
    {
        int Health { get; }
        void Damage(int damage);
    }
}
