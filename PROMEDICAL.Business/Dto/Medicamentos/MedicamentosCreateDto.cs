namespace PROMEDICAL.Business.Dto
{
    public class MedicamentosCreateDto
    {
        public string medi_Nombre { get; set; }
        public decimal medi_Precio { get; set; }
        public string medi_Descripcion { get; set; }
        public int medi_UsuarioRegistra { get; set; }
    }
}
