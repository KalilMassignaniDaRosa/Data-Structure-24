using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapaJogo
{
    public static class TerrainEnumExtensions {
        public static ConsoleColor GetColor(this TerrainEnum terrain){
            switch (terrain){
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.Blue;
                case TerrainEnum.FLAG: return ConsoleColor.Red;
                case TerrainEnum.PORTAL: return ConsoleColor.DarkMagenta;
                default: return ConsoleColor.DarkGray;
            }
        }


        public static char GetChar(this TerrainEnum terrain){
            switch (terrain){
                //Unicode para Aspas duplas
                case TerrainEnum.GRASS: return '\u201c';
                //Unicode para Circulo Oco
                case TerrainEnum.SAND: return '\u25cb';
                //Unicode para Aproximadamente Igual
                case TerrainEnum.WATER: return '\u2248';
                //Unicode para Bandeira
                case TerrainEnum.FLAG: return '\u2691';
                //Icode de
                case TerrainEnum.PORTAL: return '\u00A7';
                //Unicode para Circulo Cheio
                default: return '\u25cf';
            }
        }  
    }
}