namespace u3_ea_alac
{
    internal class Program
    {
        private List<EntidadMetaverso> listaEntidadMetaverse;

        internal List<EntidadMetaverso> ListaEntidadMetaverse 
        {
            get => listaEntidadMetaverse;
            set => listaEntidadMetaverse = value; 
        }

        static void Main(string[] args)
        {
            Menu.showMenu("Metaverso");
        }
    }
}