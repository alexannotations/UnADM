namespace DPRN2_U1_EA_ALAC
{
    internal class Color
    {
        private int _intensidad;
        public int Intensidad 
        { 
            get { return _intensidad; } 
            set { _intensidad = value>=0&&value<=100 ? value : 0;} 
        }
        public string ColorIris { get; set; }

        public Color(string color, int intensidad) 
        {
            this.ColorIris = color;
            this.Intensidad = intensidad;
        }
    }
}
