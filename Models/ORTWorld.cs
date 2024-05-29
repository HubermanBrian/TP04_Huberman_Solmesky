public static class ORTWorld
{
    public static List < string > ListaDestinos {get; private set;}
    public static List < string > ListaHoteles {get; private set;}
    public static List< string > ListaAereos {get; private set;}
    public static List< string > ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        if(Paquetes.ContainsKey(destinoSeleccionado))
        {
           return true;
        }
        else
        {
            Paquetes.Add(destinoSeleccionado,paquete);
            ListaDestinos.Add(destinoSeleccionado);
            ListaHoteles.Add(paquete.Hotel);
            ListaAereos.Add(paquete.Aereo);
            ListaExcursiones.Add(paquete.Excursion);
            return false;
        }
    }

}
