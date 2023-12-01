namespace AgendaMVC.Interfaces
{
    public interface ICrud<T>
    {
        public bool Salvar(T t);
    }
}
