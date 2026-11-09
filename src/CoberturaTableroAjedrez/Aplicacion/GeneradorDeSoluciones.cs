using System;
using System.Collections.Generic;
using CoberturaTableroAjedrez.Dominio;

namespace CoberturaTableroAjedrez.Aplicacion;

internal static class GeneradorDeSoluciones
{
    internal static List<Tablero> Generar()
    {
        int ID = 0;
        Tablero Juego = new Tablero(ID);
        Random rnd = new Random();

        Ficha Reina = new Reina("Reina");
        Ficha Rey = new Rey("Rey");
        Ficha Torre1 = new Torre("Torre1");
        Ficha Torre2 = new Torre("Torre2");
        Ficha Alfil1 = new Alfil("Alfil1");
        Ficha Alfil2 = new Alfil("Alfil2");
        Ficha Caballo1 = new Caballo("Caballo1");
        Ficha Caballo2 = new Caballo("Caballo2");

        List<Casilla> Cuadrado1 = new List<Casilla>(4);
        List<Casilla> Cuadrado2 = new List<Casilla>(12);
        List<Casilla> Cuadrado3 = new List<Casilla>(20);
        List<Casilla> Cuadrado4 = new List<Casilla>(28);

        List<Tablero> ListaSoluciones = new List<Tablero>();

        while (ListaSoluciones.Count < 11)
        {
            for (uint i = 3; i <= 4; i++)
            {
                for (uint j = 3; j <= 4; j++)
                    Cuadrado1.Add(new Casilla(i, j));
            }

            for (uint i = 2; i <= 5; i++)
            {
                Cuadrado2.Add(new Casilla(2, i));
                Cuadrado2.Add(new Casilla(5, i));
            }

            for (uint i = 3; i < 5; i++)
            {
                Cuadrado2.Add(new Casilla(i, 2));
                Cuadrado2.Add(new Casilla(i, 5));
            }

            for (uint i = 1; i <= 6; i++)
            {
                Cuadrado3.Add(new Casilla(1, i));
                Cuadrado3.Add(new Casilla(6, i));
            }

            for (uint i = 2; i < 6; i++)
            {
                Cuadrado3.Add(new Casilla(i, 1));
                Cuadrado3.Add(new Casilla(i, 6));
            }

            for (uint i = 0; i < ConfiguracionTablero.Dimension; i++)
            {
                Cuadrado4.Add(new Casilla(0, i));
                Cuadrado4.Add(new Casilla(7, i));
            }

            for (uint i = 1; i < 7; i++)
            {
                Cuadrado4.Add(new Casilla(i, 0));
                Cuadrado4.Add(new Casilla(i, 7));
            }

            Juego.Posicionar(Reina, Cuadrado1);
            Juego.Posicionar(Alfil1, Cuadrado1);
            Juego.Posicionar(Alfil2, Cuadrado2);
            Juego.Posicionar(Caballo1, Cuadrado2);
            Juego.Posicionar(Rey, Cuadrado3);
            Juego.Posicionar(Torre1, Cuadrado4);

            switch (Convert.ToInt32(rnd.Next(1, 4)))
            {
                case 1:
                    Juego.Posicionar(Torre2, Cuadrado2); break;
                case 2:
                    Juego.Posicionar(Torre2, Cuadrado3); break;
                case 3:
                    Juego.Posicionar(Torre2, Cuadrado4); break;
            }

            Juego.Posicionar(Caballo2, Cuadrado2);

            if (Juego.VerificarSolucion())
            {
                ListaSoluciones.Add(new Tablero(Juego, ID));
                ++ID;
                Juego.ImprimirOutput();

                Tablero Rotado1 = new Tablero(Juego, ++ID);
                Rotado1.Rotar90();
                ListaSoluciones.Add(Rotado1);
                Rotado1.ImprimirOutput();

                Tablero Rotado2 = new Tablero(Rotado1, ++ID);
                Rotado2.Rotar90();
                ListaSoluciones.Add(Rotado2);
                Rotado2.ImprimirOutput();

                Tablero Rotado3 = new Tablero(Rotado2, ++ID);
                Rotado3.Rotar90();
                ListaSoluciones.Add(Rotado3);
                Rotado3.ImprimirOutput();

                Tablero Espejado = new Tablero(++ID);
                Juego.Espejar(Espejado);
                ListaSoluciones.Add(Espejado);
                Espejado.ImprimirOutput();

                Tablero EspejadoRotado1 = new Tablero(Espejado, ++ID);
                ++ID;
                EspejadoRotado1.Rotar90();
                ListaSoluciones.Add(EspejadoRotado1);
                EspejadoRotado1.ImprimirOutput();

                Tablero EspejadoRotado2 = new Tablero(EspejadoRotado1, ++ID);
                EspejadoRotado2.Rotar90();
                ListaSoluciones.Add(EspejadoRotado2);
                EspejadoRotado2.ImprimirOutput();

                Tablero EspejadoRotado3 = new Tablero(EspejadoRotado2, ++ID);
                EspejadoRotado3.Rotar90();
                ListaSoluciones.Add(EspejadoRotado3);
                EspejadoRotado3.ImprimirOutput();

                Tablero Intercambiado = new Tablero(Juego, ++ID);
                Intercambiado.IntercambiarTorres();
                ListaSoluciones.Add(Intercambiado);
                Intercambiado.ImprimirOutput();

                Tablero IntercambioRotado1 = new Tablero(Intercambiado, ++ID);
                IntercambioRotado1.Rotar90();
                ListaSoluciones.Add(IntercambioRotado1);
                IntercambioRotado1.ImprimirOutput();

                Tablero IntercambioRotado2 = new Tablero(IntercambioRotado1, ++ID);
                IntercambioRotado2.Rotar90();
                ListaSoluciones.Add(IntercambioRotado2);
                IntercambioRotado2.ImprimirOutput();

                Tablero IntercambioRotado3 = new Tablero(IntercambioRotado2, ++ID);
                IntercambioRotado3.Rotar90();
                ListaSoluciones.Add(IntercambioRotado3);
                IntercambioRotado3.ImprimirOutput();
            }

            Juego.Limpiar();
            Cuadrado1.Clear();
            Cuadrado2.Clear();
            Cuadrado3.Clear();
            Cuadrado4.Clear();
        }

        return ListaSoluciones;
    }
}
