using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.src.Service
{
    public class ServicosService : IServicosService
    {
        private readonly IServicosRepository _servicosRepository;
        public ServicosService(IServicosRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public void Create(Servicos servicos)
        {
            _servicosRepository.Create(servicos);
        }

        public bool Delete(int id)
        {
            return _servicosRepository.Delete(id);
        }

        public Servicos Get(int id)
        {
            return (_servicosRepository.Get(id));
        }

        public List<Servicos> List()
        {
            return _servicosRepository.List();
        }

        public void Update(int id, Servicos servicos)
        {
            _servicosRepository.Update(id, servicos);
        }
    }
}
