﻿using System.Text;
using GameMap;

TerrainEnum[,] map ={
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
    TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS }, 

    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND,
    TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND,
    TerrainEnum.SAND },

    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
    TerrainEnum.WATER },

    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
    TerrainEnum.WATER },

    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
    TerrainEnum.WATER },

    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND,
    TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND,
    TerrainEnum.SAND },

    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
    TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS },

    { TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.FLAG,
    TerrainEnum.GRASS },

    { TerrainEnum.GRASS, TerrainEnum.PORTAL, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS },
    
    { TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS }
};

// Certificando de usar o UTF8
Console.OutputEncoding = UTF8Encoding.UTF8;

for (int row = 0; row < map.GetLength(0); row++){
    for (int column = 0; column < map.GetLength(1); column++){
        Console.ForegroundColor = map[row, column].GetColor();
        Console.Write(map[row, column].GetChar() + " ");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Gray;