namespace AgendaMVC.Interfaces
{
    public interface ICrud<T>
    {
        bool Salvar(T t);
        List<T> Consultar();
        T Consultar(int id);
        bool Alterar(T t);
        bool Deletar(T t);
    }
}
