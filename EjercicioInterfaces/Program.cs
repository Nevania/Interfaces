// See https://aka.ms/new-console-template for more information


using EjercicioInterfaces;

public class EjecutarPerro
{
    public static void Main()
    {
        PerroGrande perroGrande = new PerroGrande { Alto = 50, Peso = 50, Edad = 5 };
        PerroPequeño perroPequeño = new PerroPequeño { Alto = 30, Peso = 5, Edad = 2 };

        perroGrande.Ladrar();
        perroGrande.Correr();
        perroGrande.Trepar();

        perroPequeño.Ladrar();
        perroPequeño.Correr();
        perroPequeño.Trepar();
    }
}
