namespace CoberturaTableroAjedrez.Dominio;

internal static class ConfiguracionTablero
{
    private static int dimension = 8;

    public static int Dimension
    {
        get { return dimension; }
        set { dimension = value; }
    }
}
