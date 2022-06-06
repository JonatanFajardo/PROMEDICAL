namespace PROMEDICAL.Business.Dto
{
    public class PesosUpdateDto
    {

        public int peso_Id { get; set; }
        public int paci_Id { get; set; }
        public string peso_Descripcion { get; set; }
        public int? peso_UsuarioModifica { get; set; }
    }
}
