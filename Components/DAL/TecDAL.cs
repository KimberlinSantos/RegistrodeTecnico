namespace RegistrodeTecnico.Components.DAL
{
    public class TecDAL
    {
        private List<TecDAL> technicians = new List<TecDAL>();
        private object tecnico;
        private object tecDAL;

        public List<TecDAL> GetAllTechnicians()
        {
            return technicians;
        }

        public void AddTechnician(TecDAL technician)
        {
            if (!technicians.Any(t => t.Nombres == tecnico.Nombres))
            {
                tecDAL.TecnicoId = tecDAL.Count + 1;
                tecDAL.Add(tecDAL);
            }
            else
            {
                throw new Exception("Ya existe un técnico con ese nombre.");
            }
        }
    }
}
