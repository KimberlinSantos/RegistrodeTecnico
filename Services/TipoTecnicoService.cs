using RegistrodeTecnico.Components.Models;

namespace RegistrodeTecnico.Services
{
    public class TipoTecnicoService
    {
        private readonly HttpClient _httpClient;

        public TipoTecnicoService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IEnumerable<TipoTecnico>> GetTiposTecnicos()
        {
            var response = await _httpClient.GetAsync("api/tipostecnico");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<TipoTecnico>>();
            }
            else
            {
                throw new Exception("Error al obtener tipos técnicos");
            }
        }

        public async Task AddTipoTecnico(TipoTecnico tipoTecnico)
        {
            var response = await _httpClient.PostAsJsonAsync("api/tipostecnico", tipoTecnico);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al agregar tipo técnico");
            }
        }

        public async Task UpdateTipoTecnico(TipoTecnico tipoTecnico)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/tipostecnico/{tipoTecnico.TipoId}", tipoTecnico);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al actualizar tipo técnico");
            }
        }

        public async Task DeleteTipoTecnico(int tipoId)
        {
            var response = await _httpClient.DeleteAsync($"api/tipostecnico/{tipoId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al eliminar tipo técnico");
            }
        }
    }

}
