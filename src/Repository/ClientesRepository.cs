using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        private List<Clientes> cliente = new List<Clientes>
        {
            new Clientes
            {
                id = 1,
                name = "Sandrita",
                number = "34999999999"
            }
        };
        public void Create(Clientes clientes)
        {
            cliente.Add(clientes);
        }

        public bool Delete(int id)
        {
            var clienteDB = cliente.FirstOrDefault(x => x.id == id);
            cliente.Remove(clienteDB);
            return true;
        }

        public Clientes Get(int id)
        {
            return cliente.FirstOrDefault(x => x.id == id)!;
        }

        public List<Clientes> List()
        {
            return cliente;
        }

        public void Update(int id, Clientes clientes)
        {
            var clienteDB = cliente.FirstOrDefault(x => x.id == id);
            clienteDB.name = clientes.name;
            clienteDB.number = clientes.number;
        }
    }
}
