namespace PROMEDICAL.Business.Dto
{
    public class Jornadas_UpdateDto
    {
        public int jorn_Id { get; set; }

        public string jorn_Descripcion { get; set; }
        public int? jorn_UsuarioModifica { get; set; }
    }
}
