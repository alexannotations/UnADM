namespace DPRN2_U1_EA_ALAC
{
    internal class Iris
    {
        public string PatronTextura { get; set; }
        public string Forma { get; set; }
        public Color colorIris { get; set; }
        public string[] PatronRayas { get; set; }
        public double[] Curvatura { get; set; }
        public string Otros { get; set; }

        public Iris() 
        {
        }

        public Iris(Color color, string patronTextura, string forma, string[] patronRayas, double[] curvatura)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            colorIris = color;
            PatronRayas = patronRayas;
            Curvatura   = curvatura;
            //Otros = otros;
        }

        /**
         * El envejecimiento disminuye la intensidad del color con el tiempo
         * parametro tiempo transcurrido en años
         */
        public void simularEnvejecimiento(int tiempo) 
        {
            colorIris.Intensidad = (int)(colorIris.Intensidad*(Math.Pow(.992,tiempo)));
        }

        public void simularEnvejecimiento(double[] curvatura) 
        {
            this.Curvatura = curvatura;
        }

        public void simularEnvejecimiento(string otros) 
        { 
            this.Otros += " "+otros;
        }

        public override string ToString()
        {
            string rayas="";
            foreach (var raya in PatronRayas)
                 rayas += raya +", ";

            string curvas = "";
            foreach (var i in Curvatura)
                curvas += i + ", ";

            string otrosDatos = (Otros != null ? "\n\tOtros detallles: "+Otros : "");

            return "\nLa información guardada del Iris es" +
                "\n\tColor: " + colorIris.ColorIris +
                "\n\tIntensidad: " + colorIris.Intensidad + "%"+
                "\n\tPatrón de textura: " + PatronTextura +
                "\n\tForma: " + Forma +
                "\n\tPatrón de rayas: " + rayas +
                "\n\tCurvatura: " + curvas +
                 otrosDatos + "\n";
        }
        
    }
}
