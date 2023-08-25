using ControledePet.Models;

namespace ControledePet.Repositorio
{
    public interface IPetRepositorio
    {
        List<PetModel> BuscarTodos();
        PetModel ListarPorId(int id);
        PetModel Adicionar(PetModel pet);
        PetModel Atualizar(PetModel pet);

        bool Apagar(int id);

    }
}
