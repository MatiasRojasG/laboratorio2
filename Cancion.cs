﻿using System;
namespace Lab2POO
{
    public class Cancion
    {//Atributos
        private string Genero;
        private string Artista;
        private string Album;
        private string Nombre;


        //Metodos para hacer publicos los atributos
        public Cancion(string Genero,string Artista, string Album, string Nombre)
        {
            this.Genero = Genero;
            this.Artista = Artista;
            this.Album = Album;
            this.Nombre = Nombre;

        }
        public Cancion()
        {
            Genero = "Pop";
            Artista = "Ellie Goulding";
            Album = "Lights";
            Nombre = "Lights";
        }
        //Method
        public string Informacion()
        {
            return "Genero:" +Genero+" " + "Artista:" + Artista + " " + "Album:" + Album + " " + "Nombre:" + Nombre;
        }
    }

}
