using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
  public interface IRepositorio<T>
  {
    List<Serie> Lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Excluir(int id);
    void Atualiza(int id, T entidade);
    int ProximoId();
  }
}