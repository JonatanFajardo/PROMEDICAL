namespace PROMEDICAL.Business.Dto
{
    public class JornadasUpdateDto
    {
        public int jorn_Id { get; set; }

        public string jorn_Descripcion { get; set; }
        public int? jorn_UsuarioModifica { get; set; }
    }
}
