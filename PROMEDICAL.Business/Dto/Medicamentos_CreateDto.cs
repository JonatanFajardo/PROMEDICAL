namespace PROMEDICAL.Business.Dto
{
    public class Medicamentos_CreateDto
    {
        public string medi_Nombre { get; set; }
        public decimal medi_Precio { get; set; }
        public string medi_Descripcion { get; set; }
        public int medi_UsuarioRegistra { get; set; }
    }
}
