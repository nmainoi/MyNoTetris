using System;

namespace MyNoTetris.Classes
{
    internal static class BlocksHandler
    {
        private static ShapeBlocks[] BlocksArray;

        static BlocksHandler()
        {
            BlocksArray = new ShapeBlocks[]
            {
                new ShapeBlocks
                {
                    _width = 1,
                    _height = 4,
                    _blockName = "Linha",
                    _points = new int[,]
                    {
                        {1 },
                        {1 },
                        {1 },
                        {1 }
                    }
                },
                 new ShapeBlocks
                {
                    _width = 3,
                    _height = 2,
                    _blockName = "L",
                    _points = new int[,]
                    {
                        {1,0,0 },
                        {1,1,1} }
                },
                  new ShapeBlocks {
                    _width = 3,
                    _height = 2,
                    _blockName = "L - Reverso",
                    _points = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new ShapeBlocks {
                        _width = 3,
                        _height = 2,
                        _blockName = "-_",
                        _points = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new ShapeBlocks {
                        _width = 3,
                        _height = 2,
                        _blockName = "_-",
                        _points = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    },
                    new ShapeBlocks {
                        _width = 3,
                        _height = 2,
                        _blockName = "_|_",
                        _points = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new ShapeBlocks {
                        _width = 2,
                        _height = 2,
                        _blockName = "Quadrado",
                        _points = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    }
            };
        }

        public static ShapeBlocks GetRandomBlock()
        {
            var block = BlocksArray[new Random().Next(BlocksArray.Length)];
            return block;
        }
    }
}