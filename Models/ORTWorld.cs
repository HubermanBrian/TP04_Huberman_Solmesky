public static class ORTWorld
{
    public static List < string > ListaDestinos {get; private set;}
    public static List < string > ListaHoteles {get; private set;}
    public static List< string > ListaAereos {get; private set;}
    public static List< string > ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        ListaDestinos.Add(destinoSeleccionado);
        ListaHoteles.Add(paquete.Hotel);
        ListaAereos.Add(paquete.Aereo);
        ListaExcursiones.Add(paquete.Excursion);
        int i = 0;
        bool encontrado = false;    
        while (encontrado != true && Paquetes.Count > i)  
        {
            
            if (ListaDestinos[i] == destinoSeleccionado)
            {
                encontrado = true;
            }
            else
            {
                i++;
            }
        }
        if(encontrado == false){
            Paquetes.Add(destinoSeleccionado,paquete);
        }
        return encontrado;
    }

}
