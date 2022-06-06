namespace PROMEDICAL.Business.Dto
{
    public partial class PrescripcionesCreateDto
    {
        public int cita_Id { get; set; }
        public int medi_Id { get; set; }
        public string pres_Descripcion { get; set; }
        public int pres_UsuarioRegistra { get; set; }
    }
}
