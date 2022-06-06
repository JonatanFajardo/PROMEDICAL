namespace PROMEDICAL.Business.Dto
{
    public class PrescripcionesUpdateDto
    {
        public int pres_Id { get; set; }
        public int cita_Id { get; set; }
        public int medi_Id { get; set; }
        public string pres_Descripcion { get; set; }
        public int? pres_UsuarioModifica { get; set; }
    }
}
