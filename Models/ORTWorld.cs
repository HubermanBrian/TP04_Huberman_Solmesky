public static class ORTWorld
{
    public static List < string > ListaDestinos {get; private set;}
    public static List < string > ListaHoteles {get; private set;}
    public static List< string > ListaAereos {get; private set;}
    public static List< string > ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    static ORTWorld(){
        ListaDestinos = new List<string>
        {
            "Mexico",
            "Argentina",
            "España",
            "USA",
            "Italia",
            "Alemania",
            "Francia",
            "Inglaterra",
            "Brasil",
            "Colombia"
        };
         ListaHoteles = new List<string>
        {
            "Hotel 0.jfif",
            "Hotel 1.jfif",
            "Hotel 2.jfif",
            "Hotel 3.jfif",
            "Hotel 4.jfif",
            "Hotel 5.jfif",
            "Hotel 6.jfif",
            "Hotel 7.jfif",
            "Hotel 8.jfif",
            "Hotel 9.jfif"
        };
         ListaAereos = new List<string>
        {
            "Avion 0.jfif",
            "Avion 1.jfif",
            "Avion 2.jfif",
            "Avion 3.jfif",
            "Avion 4.jfif",
            "Avion 5.jfif",
            "Avion 6.jfif",
            "Avion 7.jfif",
            "Avion 8.jfif",
            "Avion 9.jfif"
        };
         ListaExcursiones = new List<string>
        {
            "excusiones 0.jfif",
            "excusiones 1.jfif",
            "excusiones 2.jfif",
            "excusiones 3.jfif",
            "excusiones 4.jfif",
            "excusiones 5.jfif",
            "excusiones 6.jfif",
            "excusiones 7.jfif",
            "excusiones 8.jfif",
            "excusiones 9.jfif"
        };
    }
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        if(Paquetes.ContainsKey(destinoSeleccionado))
        {
           return true;
        }
        else
        {
            ListaExcursiones.Add(paquete.Excursion);
            return false;
        }
    }

}
